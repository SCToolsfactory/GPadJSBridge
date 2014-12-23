﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


using log4net;
using log4net.Config;
//[assembly: log4net.Config.XmlConfigurator( Watch = true )]
[assembly: log4net.Config.XmlConfigurator( ConfigFile = "log4Net.config", Watch = true )]

namespace GPadJSBridge
{
  static class Program
  {
    private static readonly log4net.ILog log = log4net.LogManager.GetLogger( System.Reflection.MethodBase.GetCurrentMethod( ).DeclaringType );

    /* Log Levels Inc Priority
     * ALL 
     * DEBUG 
     * INFO 
     * WARN 
     * ERROR 
     * FATAL 
     * OFF
     * */
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main( )
    {
      log.InfoFormat( "\n" );
      log.InfoFormat( "GPadJSBridge - Started" );

      Application.EnableVisualStyles( );
      Application.SetCompatibleTextRenderingDefault( false );
      Application.Run( new MainForm( ) );

      log.InfoFormat( "GPadJSBridge - Ended\n" );

    }
  }
}
