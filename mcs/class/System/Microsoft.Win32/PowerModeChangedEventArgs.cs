//
// PowerModeChangedEventArgs.cs
//
// Author:
//  Johannes Roith (johannes@jroith.de)
//
// (C) 2002 Johannes Roith
//
namespace Microsoft.Win32 {

	/// <summary>
	/// </summary>
	public class PowerModeChangedEventArgs : System.EventArgs{
	
		PowerModes mymode;
		
		public PowerModeChangedEventArgs(PowerModes mode)
		{
			this.mymode = mode;
		}
		
		public PowerModes Mode {
	
			get{
				return mymode;
			}
			
		}
	
	}

}
