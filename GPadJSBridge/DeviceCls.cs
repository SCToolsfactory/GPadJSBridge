﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GPadJSBridge
{

  /// <summary>
  /// Basic device as DXInput device
  /// </summary>
  public abstract class DeviceCls
  {
    public const String DeviceClass ="UNDEF";
    public const String BlendedInput = " ";
    static public Boolean IsDeviceClass( String deviceClass ) { return false; }

    public enum InputKind
    {
      Other,
      Kbd,
      Joystick,
      Gamepad,
    }

    public abstract String DevClass { get; }
    public abstract String DevName { get; }
    public abstract System.Drawing.Color MapColor { get; }

    public abstract Boolean Activated { get; set; }
    public virtual void FinishDX( ) {}
    public virtual void ApplySettings( ){}

    public abstract String GetLastChange( );
    public abstract void GetCmdData( String cmd, out int data );
    public abstract void GetData( );
  }
}
