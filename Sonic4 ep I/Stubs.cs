using System;
using Microsoft.Xna.Framework;

public enum MessageBoxIcon { None, Error, Warning }

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

	public class GamerServicesComponent : GameComponent
	{
		public bool Enabled { get; set; } = false;
		public GamerServicesComponent(Game game) : base(game) { }
	}
}
