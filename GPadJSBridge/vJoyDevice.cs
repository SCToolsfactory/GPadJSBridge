using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using vJoyInterfaceWrap;
using SharpDX.DirectInput;
using System.Collections;

namespace GPadJSBridge
{
  public class vJoyDevice
  {
    private static readonly log4net.ILog log = log4net.LogManager.GetLogger( System.Reflection.MethodBase.GetCurrentMethod( ).DeclaringType );

    static public HID_USAGES[] HID_ITEMS = new HID_USAGES[] { 
      HID_USAGES.HID_USAGE_X, HID_USAGES.HID_USAGE_Y, HID_USAGES.HID_USAGE_Z,
      HID_USAGES.HID_USAGE_RX,HID_USAGES.HID_USAGE_RY,HID_USAGES.HID_USAGE_RZ,
      HID_USAGES.HID_USAGE_SL0,HID_USAGES.HID_USAGE_SL1,
      HID_USAGES.HID_USAGE_POV,HID_USAGES.HID_USAGE_POV,HID_USAGES.HID_USAGE_POV,HID_USAGES.HID_USAGE_POV
    };
    public static HID_USAGES HID_NOTUSED = HID_USAGES.HID_USAGE_WHL;


    // Declaring one joystick (Device id 1) and a position structure. 
    private vJoy joystick;
    private vJoy.JoystickState iReport;
    private uint m_vjID = 0;
    private long m_axisMax = 0;
    private int m_numButtons = 0;
    private int m_numContPov = 0;

    private Boolean[] m_ctrls = new Boolean[] { false, false, false, false, false, false, false, false, false, false, false, false }; // one for each JoystickCls.CtrlItems;

    // mapping items
    private DeviceCls m_xDevice = null;


    public vJoyDevice( )
    {
      // Create one joystick object and a position structure.
      joystick = new vJoy( );
      iReport = new vJoy.JoystickState( );

      EnumDevices( );
    }


    public uint DeviceID
    {
      get { return m_vjID; }
    }

    public Boolean IsvJoyAvailabe
    {
      get { return joystick.vJoyEnabled( ); }
    }

    public Boolean[] CtrlItemList
    {
      get { return m_ctrls; }
    }

    public int ButtonCount
    {
      get { return m_numButtons; }
    }

    public long AxisMax
    {
      get { return m_axisMax; }
    }

    public Boolean Enabled
    {
      get { return joystick.vJoyEnabled(); }
    }

    /// <summary>
    /// Submit the mapping for the Js to vJoy Bridge
    /// </summary>
    /// <param name="hidArray">Array[12] of HID_USAGE enums</param>
    /// <param name="maxButtons">Max number of buttons to brigde</param>
    /// <returns></returns>
    public Boolean CreateMapping( DeviceCls xDevice )
    {
      m_xDevice = xDevice;

      return ( m_xDevice != null );
    }


    /// <summary>
    /// Get the first free vJoy device
    /// </summary>
    /// <returns>a vJoy device to be used or 0 if non is avail</returns>
    private void EnumDevices( )
    {
      log.Info( "vJoyDevice-EnumDevices" );

      m_vjID = 0;
      ClearContolItems( );
      if ( !IsvJoyAvailabe ) return;

      for ( uint i=1; i <= 16; i++ ) {
        // Get the state of the requested device
        VjdStat status = joystick.GetVJDStatus( i );
        switch ( status ) {
          case VjdStat.VJD_STAT_OWN:
            log.InfoFormat( "vJoy Device {0} is already owned by this feeder\n", i );
            m_vjID = i;
            GetContolItems( );
            break;
          case VjdStat.VJD_STAT_FREE:
            log.InfoFormat( "vJoy Device {0} is free\n", i );
            m_vjID = i;
            GetContolItems( );
            break;
          case VjdStat.VJD_STAT_BUSY:
            log.InfoFormat( "vJoy Device {0} is already owned by another feeder\nCannot continue\n", i );
            break;
          case VjdStat.VJD_STAT_MISS:
            log.InfoFormat( "vJoy Device {0} is not installed or disabled\nCannot continue\n", i );
            break;
          default:
            log.InfoFormat( "vJoy Device {0} general error\nCannot continue\n", i );
            break;
        }
      }
    }

    /// <summary>
    /// Clear the availability of controls
    /// </summary>
    private void ClearContolItems( )
    {
      for ( int i=0; i < m_ctrls.Length; i++ ) {
        m_ctrls[i] = false;
      }
      m_numButtons = 0;
    }

    /// <summary>
    /// Collect the availability of controls
    /// </summary>
    private void GetContolItems( )
    {
      log.Info( "vJoyDevice-GetContolItems" );

      m_ctrls[( int )JoystickCls.CtrlItems.X] = joystick.GetVJDAxisExist( m_vjID, HID_USAGES.HID_USAGE_X );
      m_ctrls[( int )JoystickCls.CtrlItems.Y] = joystick.GetVJDAxisExist( m_vjID, HID_USAGES.HID_USAGE_Y );
      m_ctrls[( int )JoystickCls.CtrlItems.Z] = joystick.GetVJDAxisExist( m_vjID, HID_USAGES.HID_USAGE_Z );
      m_ctrls[( int )JoystickCls.CtrlItems.Xr] = joystick.GetVJDAxisExist( m_vjID, HID_USAGES.HID_USAGE_RX );
      m_ctrls[( int )JoystickCls.CtrlItems.Yr] = joystick.GetVJDAxisExist( m_vjID, HID_USAGES.HID_USAGE_RY );
      m_ctrls[( int )JoystickCls.CtrlItems.Zr] = joystick.GetVJDAxisExist( m_vjID, HID_USAGES.HID_USAGE_RZ );
      m_ctrls[( int )JoystickCls.CtrlItems.S1] = joystick.GetVJDAxisExist( m_vjID, HID_USAGES.HID_USAGE_SL0 );
      m_ctrls[( int )JoystickCls.CtrlItems.S2] = joystick.GetVJDAxisExist( m_vjID, HID_USAGES.HID_USAGE_SL1 );
      m_numContPov = joystick.GetVJDContPovNumber( m_vjID );
      for ( int i=0; i < m_numContPov; i++ ) {
        m_ctrls[( int )JoystickCls.CtrlItems.P1 + i] = true;
      }
      m_numButtons = joystick.GetVJDButtonNumber( m_vjID );
      joystick.GetVJDAxisMax( m_vjID, HID_USAGES.HID_USAGE_X, ref m_axisMax );
    }


    public String ReportProps( )
    {
      // Get the driver attributes (Vendor ID, Product ID, Version Number)
      String ret = "";
      if ( !joystick.vJoyEnabled( ) ) {
        ret = "vJoy driver not enabled: Failed Getting vJoy attributes.";
        log.Error( ret );
      }
      else {
        ret = String.Format( "{0} - {1} V {2}\n", joystick.GetvJoyManufacturerString( ), joystick.GetvJoyProductString( ), joystick.GetvJoySerialNumberString( ) );
        log.InfoFormat( ret  );
      }

      return ret;
    }


    private void CheckAvailable( )
    {
      // Check which axes are supported
      bool AxisX = joystick.GetVJDAxisExist( m_vjID, HID_USAGES.HID_USAGE_X );
      bool AxisY = joystick.GetVJDAxisExist( m_vjID, HID_USAGES.HID_USAGE_Y );
      bool AxisZ = joystick.GetVJDAxisExist( m_vjID, HID_USAGES.HID_USAGE_Z );
      bool AxisRX = joystick.GetVJDAxisExist( m_vjID, HID_USAGES.HID_USAGE_RX );
      bool AxisRY = joystick.GetVJDAxisExist( m_vjID, HID_USAGES.HID_USAGE_RY );
      bool AxisRZ = joystick.GetVJDAxisExist( m_vjID, HID_USAGES.HID_USAGE_RZ );
      // Get the number of buttons and POV Hat switchessupported by this vJoy device
      int nButtons = joystick.GetVJDButtonNumber( m_vjID );
      int ContPovNumber = joystick.GetVJDContPovNumber( m_vjID );
      int DiscPovNumber = joystick.GetVJDDiscPovNumber( m_vjID );

      // Print results
      log.InfoFormat( "\nvJoy Device {0} capabilities:\n", m_vjID );
      log.InfoFormat( "Numner of buttons\t\t{0}\n", nButtons );
      log.InfoFormat( "Numner of Continuous POVs\t{0}\n", ContPovNumber );
      log.InfoFormat( "Numner of Descrete POVs\t\t{0}\n", DiscPovNumber );
      log.InfoFormat( "Axis X\t\t{0}\n", AxisX ? "Yes" : "No" );
      log.InfoFormat( "Axis Y\t\t{0}\n", AxisX ? "Yes" : "No" );
      log.InfoFormat( "Axis Z\t\t{0}\n", AxisX ? "Yes" : "No" );
      log.InfoFormat( "Axis Rx\t\t{0}\n", AxisRX ? "Yes" : "No" );
      log.InfoFormat( "Axis Rz\t\t{0}\n", AxisRZ ? "Yes" : "No" );

    }


    public Boolean Aquire( )
    {
      // Acquire the target
      // Get the state of the requested device
      VjdStat status = joystick.GetVJDStatus( m_vjID );
      if ( ( status == VjdStat.VJD_STAT_OWN ) || ( ( status == VjdStat.VJD_STAT_FREE ) && ( !joystick.AcquireVJD( m_vjID ) ) ) ) {
        log.ErrorFormat( "Failed to acquire vJoy device number {0}.\n", m_vjID );
        return false;
      }
      log.InfoFormat( "Acquired: vJoy device number {0}.\n", m_vjID );
      // Reset this device to default values
      joystick.ResetVJD( m_vjID );

      return true;
    }

    public void Release( )
    {
      joystick.RelinquishVJD( m_vjID );
    }


    public Boolean Feed( JoystickState inState )
    {
      if ( inState == null ) return false;

      bool res = true;
      // Set position of 4 axes
      iReport.bDevice = (Byte)m_vjID;
      iReport.AxisX = inState.X;
      iReport.AxisY = inState.Y;
      iReport.AxisZ = inState.Z;
      iReport.AxisXRot = inState.RotationX;
      iReport.AxisYRot = inState.RotationY;
      iReport.AxisZRot = inState.RotationZ;


      int[] slider = inState.Sliders;
      if ( slider.Length > 0 ) iReport.Slider = slider[0];
      if ( slider.Length > 1 ) iReport.Dial = slider[1];

      // If Continuous POV hat switches installed - make them go round
      // For high values - put the switches in neutral state
      int[] pov = inState.PointOfViewControllers;
      int maxPov = (pov.Length > m_numContPov) ? m_numContPov : pov.Length;
      if ( maxPov > 0 ) iReport.bHats = ( uint )pov[0];
      if ( maxPov > 1 ) iReport.bHatsEx1 = ( uint )pov[1];
      if ( maxPov > 2 ) iReport.bHatsEx2 = ( uint )pov[2];
      if ( maxPov > 3 ) iReport.bHatsEx3 = ( uint )pov[3];


      // Press/Release Buttons
      bool[] buttons = inState.Buttons;
      int maxButtons = ( buttons.Length > m_numButtons ) ? m_numButtons : buttons.Length; // limit to minimum of IN and OUT

      BitArray arr = new BitArray(inState.Buttons);
      int[] data = new int[4]; arr.CopyTo(data, 0);
      iReport.Buttons =(uint)data[0]; // just take the first 32 items

      res = joystick.UpdateVJD( m_vjID, ref iReport );
      return res;
    }



  }
}
