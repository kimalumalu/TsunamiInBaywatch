using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuButtons : MonoBehaviour {

	public GameObject credits;
	public GameObject menuScreen;

	public Image playButton;
	public Image soundButtonActive;
	public Image soundButtonInactive;
	public Image creditsButoon;

	private bool soundActive;


	void Start () {
		menuScreen.SetActive (true);
		soundButtonActive.gameObject.SetActive (true);
		soundButtonInactive.gameObject.SetActive (false);
		soundActive = true;

	}

	public void PlayButtonClick(){
		SceneManager.LoadScene (1);
		Debug.Log ("Scene wird geladen");
	}

	public void SettingsButtonClick(){
		if (soundActive == true) {
			Debug.Log ("Klappt");
			soundActive = false;
			soundButtonActive.gameObject.SetActive (false);
			soundButtonInactive.gameObject.SetActive (true);
		} else {
			soundActive = true;
			soundButtonActive.gameObject.SetActive (true);
			soundButtonInactive.gameObject.SetActive (false);
		}
	}

	public void MainMenuButtonClick(){
		Debug.Log ("Credits geschlossen");
		OpenMainMenu ();
	}
		
	public void CreditsButtonClick(){
		OpenCredits ();
	}

	public void OpenCredits(){
		credits.SetActive (true);
		menuScreen.SetActive (false);
	}

	public void OpenMainMenu(){
		credits.SetActive (false);
		menuScreen.SetActive (true);
	}
}
