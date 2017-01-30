using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathWinButtons : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RestartGame()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene (1);
	}

	public void QuitGame()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene (0);
	}
}
