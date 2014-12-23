using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GPadJSBridge
{
  public class JoystickList : List<JoystickCls>
  {

    public Dictionary<int, int> JsReassingList { get; set; } // oldJs, newJs
    public List<int> NewJsList { get; set; }  // index is this[idx]


    public void Deactivate( )
    {
      foreach ( JoystickCls j in this ) j.Activated = false;
    }
    public void Activate( )
    {
      foreach ( JoystickCls j in this ) j.Activated =true;
    }


    /// <summary>
    /// Returns the Joystick instance for the given jsN 
    /// </summary>
    /// <param name="n">The JsN</param>
    /// <returns>The instance or null if not found</returns>
    public JoystickCls Find_jsN( int n )
    {
      foreach ( JoystickCls j in this ) {
        if ( j.JSAssignment == n ) return j;
      }
      return null;
    }


    /// <summary>
    /// Returns the Joystick instance for the given device name
    /// </summary>
    /// <param name="n">The device name</param>
    /// <returns>The instance or null if not found</returns>
    public JoystickCls Find_jsDev( String devName )
    {
      foreach ( JoystickCls j in this ) {
        if ( j.DevName == devName ) return j;
      }
      return null;
    }


    /// <summary>
    /// Returns the Joystick instance for the given device instance GUID
    /// </summary>
    /// <param name="n">The instance GUID</param>
    /// <returns>The instance or null if not found</returns>
    public JoystickCls Find_jsInstance( String instGUID )
    {
      foreach ( JoystickCls j in this ) {
        if ( j.DevInstanceGUID == instGUID ) return j;
      }
      return null;
    }


  }
}
