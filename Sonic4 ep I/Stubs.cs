using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public enum MessageBoxIcon
{
	None,
	Error,
	Warning
}

public class Accelerometer
{
	public bool IsSupported => false;
	public void Start() { }
	public void Stop() { }
}

namespace Microsoft.Devices.Sensors
{
	public class Accelerometer
	{
		public bool IsSupported => false;
		public void Start() { }
		public void Stop() { }
	}
}

namespace Microsoft.Xna.Framework
{
	public partial class Game
	{
		public object spriteBatch;
		public object fnts;
	}
}

namespace Microsoft.Xna.Framework.GamerServices
{
	public static class Guide
	{
		public static bool IsTrialMode => false;
		public static bool IsScreenSaverEnabled { get; set; } = false;

		public static IAsyncResult BeginShowMessageBox(string title, string text, System.Collections.Generic.IEnumerable<string> buttons, int focusButton, MessageBoxIcon icon, AsyncCallback callback, object state) => null;
		public static int? EndShowMessageBox(IAsyncResult result) => 0;
		public static void ShowMarketplace(PlayerIndex player) { }
	}
}
