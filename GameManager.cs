using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public enum GameState
	{
		MAINMENU,
		PLAY,
		GAMEOVER,
	}
	public GameState curGamestate;
	public GameObject MainMenu, GameOver;

	// Use this for initialization
	void Start () {
		curGamestate = GameState.MAINMENU;
		GameOver.SetActive(false);
	}

	// Update is called once per frame
	void Update () {

	}
	public void StartGame(){
		MainMenu.SetActive (false);
		GameOver.SetActive (false);
		curGamestate = GameState.PLAY;
		//ScoreScript.scoreValue = 0;
	}
	public void EndGame(){
		curGamestate = GameState.GAMEOVER;
		GameOver.SetActive (true);
	}
	public void ToMainMenu(){
		MainMenu.SetActive (true);
		GameOver.SetActive (false);
		curGamestate = GameState.MAINMENU;
	}
}
