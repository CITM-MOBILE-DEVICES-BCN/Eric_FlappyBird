using UnityEngine;
using static GameManager;

public class PlayState : IGameState
{
	public GameManager.GameState CurrentState { get; set; }
	public PlayState()
	{
		this.CurrentState = GameState.Play;
	}

	public void EnterState()
	{
		Time.timeScale = 1;
		AudioManager.Instance.PlayMusic("Theme");
	}
}
