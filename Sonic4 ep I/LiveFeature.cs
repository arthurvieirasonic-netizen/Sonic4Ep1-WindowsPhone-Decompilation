using System;
using Microsoft.Xna.Framework;

public class LiveFeature
{
	public static Game GAME;
	private static LiveFeature s_instance;

	public static LiveFeature getInstance()
	{
		if (LiveFeature.s_instance == null)
		{
			LiveFeature.s_instance = new LiveFeature();
		}
		return LiveFeature.s_instance;
	}

	// Métodos vazios só para o compilador não reclamar de métodos ausentes
	public void Initialize(Game game)
	{
		GAME = game;
	}

	public void Update(GameTime gameTime)
	{
	}

	public bool IsTrialMode()
	{
		return false; // Jogo completo, sem modo de teste
	}
}
