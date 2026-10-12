using System;
using Microsoft.Xna.Framework;

public class LiveFeature
{
	public static Game GAME;
	private static LiveFeature s_instance;
	public static string lang_suffix = "us"; // Tornou-se estático para o Upsell.cs

	public static LiveFeature getInstance()
	{
		if (LiveFeature.s_instance == null)
		{
			LiveFeature.s_instance = new LiveFeature();
		}
		return LiveFeature.s_instance;
	}

	public void Initialize(Game game)
	{
		GAME = game;
	}

	public void Update(GameTime gameTime)
	{
	}

	public bool IsTrialMode()
	{
		return false;
	}

	public bool InputOverride()
	{
		return false;
	}

	public void ShowOverride()
	{
	}
}
