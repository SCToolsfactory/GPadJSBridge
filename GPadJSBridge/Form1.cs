using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SharpDX.DirectInput;
using System.IO;

namespace GPadJSBridge
{
  public partial class MainForm : Form
  {
    private static readonly log4net.ILog log = log4net.LogManager.GetLogger( System.Reflection.MethodBase.GetCurrentMethod( ).DeclaringType );

    private const String c_GithubLink = @"https://github.com/SCToolsfactory/GPadJSBridge/releases";

    ///<remarks>
    /// Holds the DXInput Joystick List
    ///</remarks>
    private JoystickList m_Joystick = new JoystickList( );
    private JoystickCls  m_selectedJS = null;
    private JoystickCls  m_bridgeJS = null;

    ///<remarks>
    /// Holds the DXInput keyboard
    ///</remarks>
    private GamepadCls m_Gamepad = null;

    ///<remarks>
    /// Holds the vJoy device
    ///</remarks>
    private vJoyDevice m_vJoy = null;



    private Label[] m_lblIn = null;
    private Label[] m_lblOut = null;
    private CheckBox[,] m_chk = null; // row / col

    private Boolean m_loading = true;

    #region Tools section

    // Means to identify the Gamepad TabPage 
    // (the TAG is used as Int for JS as well - so don't change the ID type used)
    private const int ID_GAMEPAD_TAB = -99;
    /// <summary>
    /// Identify the Tab as Gamepad tab
    /// </summary>
    /// <param name="page">The tab page</param>
    private void SetGamepadTab( TabPage page )
    {
      page.Tag = ID_GAMEPAD_TAB;
    }
    /// <summary>
    /// Returns true if the tabPage is the Gamepad Page
    /// </summary>
    /// <param name="page">The tab page</param>
    /// <returns>True if it is the Gamepad Tab</returns>
    private Boolean IsGamepadTab( TabPage page )
    {
      // catch if the Tag is not an int...
      try {
        return ( ( int )page.Tag == ID_GAMEPAD_TAB );
      }
      catch {
        return false;
      }
    }

    /// <summary>
    /// Get the current JsN String for the active device tab
    /// </summary>
    /// <returns>The jsN string - can be jsx, js1..jsN</returns>
    private String JSStr( )
    {
      UC_JoyPanel jp = ( UC_JoyPanel )( tc1.SelectedTab.Controls["UC_JoyPanel"] );
      return jp.JsName;
    }


    #endregion


    #region Main Form Handling

    public MainForm( )
    {
      InitializeComponent( );
    }

    private void MainForm_Deactivate( object sender, EventArgs e )
    {
      if ( m_loading ) return;

      timer1.Enabled = false;
      lblDevReport.Text = "off";
      //m_Joystick.Deactivate( );
    }

    private void MainForm_Activated( object sender, EventArgs e )
    {
      if ( m_loading ) return;

      timer1.Enabled = true;
      lblDevReport.Text = "on";
      m_Joystick.Activate( );
    }

    /// <summary>
    ///  Handle the load event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MainForm_Load( object sender, System.EventArgs e )
    {
      log.Debug( "MainForm_Load - Entry" );

      // some applic initialization 
      // Assign Size property, since databinding to Size doesn't work well.

      //      this.Size = m_AppSettings.FormSize;
      //      this.Location = m_AppSettings.FormLocation;

      String version = Application.ProductVersion;  // get the version information 
      //      lblTitle.Text += " - V " + version.Substring( 0, version.IndexOf( ".", version.IndexOf( "." ) + 1 ) ); // get the first two elements (NON BETA)
            lblTitle.Text += " - beta " + version; // BETA naming
      log.InfoFormat( "Application Version: {0}", version.ToString( ) );

      // tooltips where needed
      toolTip1.SetToolTip( this.linkLblReleases, c_GithubLink ); // allow to see where the link may head

      m_vJoy = new vJoyDevice( );

      // Init X things
      log.Debug( "Loading DirectX" );
      if ( !InitDirectInput( m_vJoy.AxisMax ) ) {
        log.Fatal( "Initializing DirectXInput failed" );
        MessageBox.Show( "Initializing DirectXInput failed - program exits now", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
        Close( );
      }

      InitControls( );
      StopBridge( );

      lblvJoyDriver.Text = m_vJoy.ReportProps( );
      if ( !m_vJoy.Enabled ) {
        MessageBox.Show( "Initializing vJoy Driver failed\n - install the driver and run the test program", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
        btBStart.Enabled = false;
        btBStop.Enabled = false;
      }

      // poll the XInput
      log.Debug( "Start XInput polling" );
      timer1.Start( ); // this one polls the joysticks to show the props

      m_loading = false;
    }


    /// <summary>
    /// Handles the Exit button
    /// </summary>
    private void buttonExit_Click( object sender, System.EventArgs e )
    {
      log.Debug( "Shutting down now..." );
      Close( );
    }

    /// <summary>
    /// Fancy tab coloring with ownerdraw to paint the callout buttons
    /// </summary>
    private void tc1_DrawItem( object sender, System.Windows.Forms.DrawItemEventArgs e )
    {
      try {
        //This line of code will help you to change the apperance like size,name,style.
        Font f;
        //For background color
        Brush backBrush = new System.Drawing.SolidBrush( MyColors.TabColor[e.Index] );
        //For forground color
        Brush foreBrush = new SolidBrush( System.Drawing.Color.Black );


        //This construct will hell you to deside which tab page have current focus
        //to change the style.
        if ( e.Index == this.tc1.SelectedIndex ) {
          //This line of code will help you to change the apperance like size,name,style.
          f = new Font( e.Font, FontStyle.Bold | FontStyle.Bold );
          f = new Font( e.Font, FontStyle.Bold );

          Rectangle tabRect = tc1.Bounds;
          Region tabRegion = new Region( tabRect );
          Rectangle TabItemRect = new Rectangle( 0, 0, 0, 0 );
          for ( int nTanIndex = 0; nTanIndex < tc1.TabCount; nTanIndex++ ) {
            TabItemRect = Rectangle.Union( TabItemRect, tc1.GetTabRect( nTanIndex ) );
          }
          tabRegion.Exclude( TabItemRect );
          e.Graphics.FillRegion( backBrush, tabRegion );
        }
        else {
          f = e.Font;
          foreBrush = new SolidBrush( e.ForeColor );
        }

        //To set the alignment of the caption.
        string tabName = this.tc1.TabPages[e.Index].Text;
        StringFormat sf = new StringFormat( );
        sf.Alignment = StringAlignment.Center;

        //Thsi will help you to fill the interior portion of
        //selected tabpage.
        e.Graphics.FillRectangle( backBrush, e.Bounds );
        Rectangle r = e.Bounds;
        r = new Rectangle( r.X, r.Y + 3, r.Width, r.Height - 3 );
        e.Graphics.DrawString( tabName, f, foreBrush, r, sf );

        sf.Dispose( );
        if ( e.Index == this.tc1.SelectedIndex ) {
          f.Dispose( );
          backBrush.Dispose( );
        }
        else {
          backBrush.Dispose( );
          foreBrush.Dispose( );
        }
      }
      catch ( Exception Ex ) {
        log.Error( "Ex DrawItem", Ex );
        MessageBox.Show( Ex.Message.ToString( ), "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Information );
      }

    }

    #endregion


    #region Initializations

    /// <summary>
    /// Resets the Action Tree
    /// </summary>
    private void InitDefaultMapping( )
    {
      log.Debug( "InitDefaultMapping - Entry" );

      // apply a default JS to Joystick mapping - can be changed and reloaded from XML mappings
      // must take care of Gamepads if there are (but we take care of one only...)

      int joyStickIndex = 0; // Joystick List Index
      for ( int deviceTabIndex=0; deviceTabIndex < JoystickCls.JSnum_MAX; deviceTabIndex++ ) {
        if ( tc1.TabPages.Count > deviceTabIndex ) {
          // valid Device Tab
          if ( IsGamepadTab( tc1.TabPages[deviceTabIndex] ) ) {
            ; // ignore Xpad gamepads
          }
          else if ( m_Joystick.Count > joyStickIndex ) {
            // there is a joystick device left..
            m_Joystick[joyStickIndex].JSAssignment = joyStickIndex + 1; // assign number 1..
            joyStickIndex++;
          }
        }
      }
    }


    private void InitControls( )
    {
      if ( m_selectedJS == null ) return;

      m_lblIn = new Label[] { lbInX, lbInY, lbInZ, lbInXr, lbInYr, lbInZr, lbInS1, lbInS2, lbInP1, lbInP2, lbInP3, lbInP4, lbInBt };
      m_lblOut = new Label[] { lbOutX, lbOutY, lbOutZ, lbOutXr, lbOutYr, lbOutZr, lbOutS1, lbOutS2, lbOutP1, lbOutP2, lbOutP3, lbOutP4, lbOutBt };


      Boolean[] jSctrlItemList = m_selectedJS.CtrlItemList;
      for ( int r=0; r < 12; r++ ) {
        m_lblIn[r].Visible = jSctrlItemList[r];
      }
      lbInBt.Text = String.Format( "#B {0}", m_selectedJS.ButtonCount.ToString( "000" ) );

      Boolean[] vJctrlItemList = m_vJoy.CtrlItemList;
      for ( int c=0; c < 12; c++ ) {
        m_lblOut[c].Visible = vJctrlItemList[c];
      }
      lbOutBt.Text = String.Format( "#B {0}", m_vJoy.ButtonCount.ToString( "000" ) );

      tlpGrid.Visible = false;
      // tlpGrid.SuspendLayout( );

      if ( m_chk == null ) {
        // create all checkboxes
        m_chk = new CheckBox[12, 12];
        for ( int r=0; r < 12; r++ ) {
          for ( int c=0; c < 12; c++ ) {
            CheckBox chk = new CheckBox( ); chk.Text = "";
            m_chk[r, c] = chk; m_chk[r, c].Visible = vJctrlItemList[c] && jSctrlItemList[r]; m_chk[r, c].Checked = ( r == c );

            tlpGrid.Controls.Add( chk );
            tlpGrid.SetRow( chk, r + 1 );
            tlpGrid.SetColumn( chk, c + 1 );
          }
        }
      }
      else {
        // only clear them 
        for ( int r=0; r < 12; r++ ) {
          for ( int c=0; c < 12; c++ ) {
            m_chk[r, c].Visible = vJctrlItemList[c] && jSctrlItemList[r]; m_chk[r, c].Checked = ( r == c );
          }
        }
      }

      //tlpGrid.ResumeLayout( );
      tlpGrid.Visible = true;

    }


    /// <summary>
    /// Aquire the DInput joystick devices
    /// </summary>
    /// <returns></returns>
    public bool InitDirectInput( long axisMax )
    {
      log.Debug( "Entry" );

      // Enumerate joysticks in the system.
      int tabs = 0;
      SharpDX.XInput.UserIndex gpDeviceIndex = SharpDX.XInput.UserIndex.Any;

      try {
        // Initialize DirectInput
        log.Debug( "Instantiate DirectInput" );
        var directInput = new DirectInput( );

        // scan the Input for attached devices
        log.Debug( "Scan GameControl devices" );
        int nJs = 1; // number the Joystick Tabs
        foreach ( DeviceInstance instance in directInput.GetDevices( DeviceClass.GameControl, DeviceEnumerationFlags.AttachedOnly ) ) {

          log.InfoFormat( "GameControl: #{0} Type:{1} Device:{2}", tabs, instance.Type.ToString( ), instance.ProductName );
          // Create the device interface
          log.Debug( "Create the device interface" );
          SharpDX.DirectInput.Joystick jsDevice = null;
          SharpDX.XInput.Controller gpDevice = null;
          JoystickCls js = null; GamepadCls gs = null;
          if ( false && (instance.Usage == SharpDX.Multimedia.UsageId.GenericGamepad ) ) { // DON'T
            // detect Gamepad only if the user wishes to do so
            for ( SharpDX.XInput.UserIndex i =  SharpDX.XInput.UserIndex.One; i < SharpDX.XInput.UserIndex.Four; i++ ) {
              gpDevice = new SharpDX.XInput.Controller( i );
              if ( gpDevice.IsConnected ) {
                log.InfoFormat( "Scan Input {0} for gamepad - {1}", i, gpDevice.GetCapabilities( SharpDX.XInput.DeviceQueryType.Gamepad ).ToString( ) );
                gpDeviceIndex = i;
                break;
              }
            }
          }
          else {
            jsDevice = new Joystick( directInput, instance.InstanceGuid );
            log.DebugFormat( "Create the device interface for: {0}", jsDevice.Information.ProductName );
          }

          // we have the first tab made as reference so TabPage[0] already exists
          if ( tabs == 0 ) {
            // first panel - The Tab content exists already 
            if ( gpDevice != null ) {
              log.Debug( "Add first Gamepad panel" );
              tc1.TabPages[0].Text = "Gamepad ";
              UC_GpadPanel uUC_GpadPanelNew = new UC_GpadPanel( ); tc1.TabPages[0].Controls.Add( uUC_GpadPanelNew );
              uUC_GpadPanelNew.Size = UC_JoyPanel.Size; uUC_GpadPanelNew.Location = UC_JoyPanel.Location;
              UC_JoyPanel.Enabled = false; UC_JoyPanel.Visible = false; // don't use this one 
              log.Debug( "Create Gamepad instance" );
              gs = new GamepadCls( gpDevice, uUC_GpadPanelNew, 0 ); // does all device related activities for that particular item
              gs.SetDeviceName( instance.ProductName );
            }
            else {
              log.Debug( "Add first Joystick panel" );
              log.Debug( "Create Joystick instance" );
              tc1.TabPages[tabs].Text = String.Format( "Joystick {0}", nJs++ );
              js = new JoystickCls( jsDevice, this, tabs + 1, UC_JoyPanel, 0, axisMax ); // does all device related activities for that particular item
            }
          }
          else {
            if ( gpDevice != null ) {
              log.Debug( "Add next Gamepad panel" );
              tc1.TabPages.Add( "Gamepad " );
              UC_GpadPanel uUC_GpadPanelNew = new UC_GpadPanel( ); tc1.TabPages[tabs].Controls.Add( uUC_GpadPanelNew );
              uUC_GpadPanelNew.Size = UC_JoyPanel.Size; uUC_GpadPanelNew.Location = UC_JoyPanel.Location;
              UC_JoyPanel.Enabled = false; UC_JoyPanel.Visible = false; // don't use this one 
              log.Debug( "Create Gamepad instance" );
              gs = new GamepadCls( gpDevice, uUC_GpadPanelNew, tabs ); // does all device related activities for that particular item
              gs.SetDeviceName( instance.ProductName );
            }
            else {
              log.Debug( "Add next Joystick panel" );
              // setup the further tab contents along the reference one in TabPage[0] (the control named UC_JoyPanel)
              tc1.TabPages.Add( String.Format( "Joystick {0}", nJs++ ) );
              UC_JoyPanel uUC_JoyPanelNew = new UC_JoyPanel( ); tc1.TabPages[tabs].Controls.Add( uUC_JoyPanelNew );
              uUC_JoyPanelNew.Size = UC_JoyPanel.Size; uUC_JoyPanelNew.Location = UC_JoyPanel.Location;
              log.Debug( "Create Joystick instance" );
              js = new JoystickCls( jsDevice, this, tabs + 1, uUC_JoyPanelNew, tabs, axisMax ); // does all device related activities for that particular item
            }
          }

          if ( gpDevice != null ) {
            m_Gamepad = gs;
            SetGamepadTab( tc1.TabPages[tabs] );  // indicates the gamepad tab (murks..)
            MyColors.GamepadColor = MyColors.TabColor[tabs]; // save it for future use
          }
          else if ( js != null ) {
            m_Joystick.Add( js ); // add to joystick list
            tc1.TabPages[tabs].Tag = ( m_Joystick.Count - 1 );  // used to find the tab for polling
          }
          tc1.TabPages[tabs].BackColor = MyColors.TabColor[tabs]; // each tab has its own color

          // next tab
          tabs++;
          if ( tabs >= JoystickCls.JSnum_MAX ) break; // cannot load more JSticks than predefined Tabs
        }
        log.DebugFormat( "Added {0} GameControl devices", tabs );

        if ( tabs == 0 ) {
          log.Warn( "Unable to find and/or create any joystick devices." );
          MessageBox.Show( "Unable to create a joystick device. Program will exit.", "No joystick found", MessageBoxButtons.OK, MessageBoxIcon.Information );
          return false;
        }

        // load the profile items from the XML
        log.Debug( "InitDefaultMapping" );
        InitDefaultMapping( );

      }
      catch ( Exception ex ) {
        log.Debug( "InitDirectInput failed unexpectedly", ex );
        return false;
      }

      return true;
    }


    #endregion


    private Boolean CheckMapping( )
    {
      if ( m_selectedJS == null ) {
        MessageBox.Show( String.Format( "There is no valid Device Tab selected \n - click the tab to bridge before starting!"),
                                        "Mapping Check", MessageBoxButtons.OK, MessageBoxIcon.Warning );
        return false;
      }

      Boolean rowChecked = false;
      for ( int r=0; r < 12; r++ ) {
        rowChecked = false;
        for ( int c=0; c < 12; c++ ) {
          if ( m_chk[r, c].Checked )
            if ( rowChecked ) {
              MessageBox.Show( String.Format( "The row {0} has more than one mapping\n - only one map is allowed!", m_lblIn[r].Text ),
                                              "Mapping Check", MessageBoxButtons.OK, MessageBoxIcon.Warning );
              return false;
            }
            else {
              rowChecked = true;
            }
        }
      }
      return true;
    }


    private Boolean SetupBridge( )
    {
      if ( !CheckMapping( ) ) return false;

      m_bridgeJS = m_selectedJS;

      lblFrom.Text = m_bridgeJS.DevName;

      return m_vJoy.CreateMapping( m_bridgeJS ); ;
    }


    private void RunBridge( )
    {
      if ( m_vJoy.Aquire( ) ) {
        timer2.Enabled = true;
      }
      else {
        MessageBox.Show( String.Format( "Cannot aquire vJoy device \n - something is wrong - sorry!" ),
                                        "Rund Bridge", MessageBoxButtons.OK, MessageBoxIcon.Error );
        StopBridge( );
      }
    }


    private void StopBridge( )
    {
      m_vJoy.Release( );
      timer2.Enabled = false;
      lblFrom.Text = "not active";
    }


    #region Event Handling

    // Form Events

    private void MainForm_FormClosing( object sender, FormClosingEventArgs e )
    {
      log.Debug( "MainForm_FormClosing - Entry" );

      if ( m_vJoy != null ) {
        m_vJoy.Release( );
      }
    }

    private void tc1_Selected( object sender, TabControlEventArgs e )
    {
      String devName = ( tc1.SelectedTab.Controls["UC_JoyPanel"] as UC_JoyPanel ).Caption;
      if ( devName.ToLower( ).Contains( "vjoy" ) ) {
        m_selectedJS = null;
      }
      else {
        m_selectedJS = m_Joystick.Find_jsDev( devName );
        lblDevice.Text = devName;
        InitControls( );
      }
    }

    private void linkLblReleases_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
    {
      this.linkLblReleases.LinkVisited = true;
      System.Diagnostics.Process.Start( c_GithubLink );
    }


    private void btBStart_Click( object sender, EventArgs e )
    {
      btBStart.Enabled = false;
      if ( SetupBridge( ) ) {
        RunBridge( );
      }
      else {
        StopBridge( );
      }

    }

    private void btBStop_Click( object sender, EventArgs e )
    {
      StopBridge( );
      btBStart.Enabled = true;
    }


    private void timer1_Tick( object sender, System.EventArgs e )
    {
      if ( m_loading ) return;

      String ctrl = "";
      int jsIndex = ( int )tc1.SelectedTab.Tag; // gets the index into the JS list
      if ( jsIndex < 0 ) {
        m_Gamepad.GetData( );
        ctrl = m_Gamepad.GetLastChange( );
        timer1.Interval = 750; // allow more time to release buttons
      }
      else {
        m_Joystick[jsIndex].GetData( );  // poll the device
        ctrl = JSStr( ) + m_Joystick[jsIndex].GetLastChange( ); // show last handled JS control
        timer1.Interval = 100; // standard polling
      }

    }

    private void timer2_Tick( object sender, EventArgs e )
    {
      if ( m_loading ) return;

      if ( m_bridgeJS == null ) return;
      m_vJoy.Feed( m_bridgeJS.GetState( ) );  // poll the device
    }

    #endregion



  }
}
