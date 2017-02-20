using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScreenFading : MonoBehaviour {

	// Start menu objects
	public Image logo;
	public Image startButton;
	public Image muteButton;
	public Image aboutButton;
	public Text startText;
	public Text muteText;
	public Text aboutText;
	private bool muted;

	// Level choice menu objects
	public Image easyButton;
	public Image easyButtonImage;
	public Text easyButtonText;
	public Image normalButton;
	public Image normalButtonImage;
	public Text normalButtonText;
	public Image hardButton;
	public Image hardButtonImage;
	public Text hardButtonText;
	public Image choiceMenuBackButton;
	public Text choiceMenuBackButtonText;

	// About menu objects
	public Text jobTitle1;
	public Text name1;
	public Text jobTitle2;
	public Text name2;
	public Image aboutMenuBackButton;
	public Text aboutMenuBackButtonText;

	// Use this for initialization
	void Start () {
//		muted = false;
//		easyButton.CrossFadeAlpha(0.0f, 0.0001f, false);
//		easyButtonImage.CrossFadeAlpha(0.0f, 0.0001f, false);
//		easyButtonText.CrossFadeAlpha(0.0f, 0.0001f, false);
//		normalButton.CrossFadeAlpha(0.0f, 0.0001f, false);
//		normalButtonImage.CrossFadeAlpha(0.0f, 0.0001f, false);
//		normalButtonText.CrossFadeAlpha(0.0f, 0.0001f, false);
//		hardButton.CrossFadeAlpha(0.0f, 0.0001f, false);
//		hardButtonImage.CrossFadeAlpha(0.0f, 0.0001f, false);
//		hardButtonText.CrossFadeAlpha(0.0f, 0.0001f, false);
//		jobTitle1.CrossFadeAlpha(0.0f, 0.0001f, false);
//		name1.CrossFadeAlpha(0.0f, 0.0001f, false);
//		jobTitle2.CrossFadeAlpha(0.0f, 0.0001f, false);
//		name2.CrossFadeAlpha(0.0f, 0.0001f, false);
//		choiceMenuBackButton.CrossFadeAlpha(0.0f, 0.0001f, false);
//		choiceMenuBackButtonText.CrossFadeAlpha(0.0f, 0.0001f, false);
//		aboutMenuBackButton.CrossFadeAlpha(0.0f, 0.0001f, false);
//		aboutMenuBackButtonText.CrossFadeAlpha(0.0f, 0.0001f, false);

		easyButton.gameObject.SetActive(false);
		normalButton.gameObject.SetActive(false);
		hardButton.gameObject.SetActive(false);
		choiceMenuBackButton.gameObject.SetActive(false);
		aboutMenuBackButton.gameObject.SetActive(false);
	}

	public void FadeOutStartScreen() {
		logo.CrossFadeAlpha(0.0f, 1.0f, false);
		startButton.CrossFadeAlpha(0.0f, 1.0f, false);
		muteButton.CrossFadeAlpha(0.0f, 1.0f, false);
		aboutButton.CrossFadeAlpha(0.0f, 1.0f, false);
		startText.CrossFadeAlpha(0.0f, 1.0f, false);
		muteText.CrossFadeAlpha(0.0f, 1.0f, false);
		aboutText.CrossFadeAlpha(0.0f, 1.0f, false);
	}

	public void FadeInStartScreen() {
		logo.CrossFadeAlpha(1.0f, 1.0f, false);
		startButton.CrossFadeAlpha(1.0f, 1.0f, false);
		muteButton.CrossFadeAlpha(1.0f, 1.0f, false);
		aboutButton.CrossFadeAlpha(1.0f, 1.0f, false);
		startText.CrossFadeAlpha(1.0f, 1.0f, false);
		muteText.CrossFadeAlpha(1.0f, 1.0f, false);
		aboutText.CrossFadeAlpha(1.0f, 1.0f, false);
	}

	public void FadeOutChoiceScreen() {
		easyButton.CrossFadeAlpha(0.0f, 1.0f, false);
		easyButtonImage.CrossFadeAlpha(0.0f, 1.0f, false);
		easyButtonText.CrossFadeAlpha(0.0f, 1.0f, false);
		normalButton.CrossFadeAlpha(0.0f, 1.0f, false);
		normalButtonImage.CrossFadeAlpha(0.0f, 1.0f, false);
		normalButtonText.CrossFadeAlpha(0.0f, 1.0f, false);
		hardButton.CrossFadeAlpha(0.0f, 1.0f, false);
		hardButtonImage.CrossFadeAlpha(0.0f, 1.0f, false);
		hardButtonText.CrossFadeAlpha(0.0f, 1.0f, false);

		easyButton.gameObject.SetActive(false);
		normalButton.gameObject.SetActive(false);
		hardButton.gameObject.SetActive(false);
		choiceMenuBackButton.gameObject.SetActive(false);

		startButton.gameObject.SetActive(true);
		muteButton.gameObject.SetActive(true);
		aboutButton.gameObject.SetActive(true);
		FadeInStartScreen();
	}

	public void FadeInChoiceScreen() {
		FadeOutStartScreen();

		easyButton.gameObject.SetActive(true);
		normalButton.gameObject.SetActive(true);
		hardButton.gameObject.SetActive(true);
		choiceMenuBackButton.gameObject.SetActive(true);

		easyButton.CrossFadeAlpha(1.0f, 1.0f, false);
		easyButtonImage.CrossFadeAlpha(1.0f, 1.0f, false);
		easyButtonText.CrossFadeAlpha(1.0f, 1.0f, false);
		normalButton.CrossFadeAlpha(1.0f, 1.0f, false);
		normalButtonImage.CrossFadeAlpha(1.0f, 1.0f, false);
		normalButtonText.CrossFadeAlpha(1.0f, 1.0f, false);
		hardButton.CrossFadeAlpha(1.0f, 1.0f, false);
		hardButtonImage.CrossFadeAlpha(1.0f, 1.0f, false);
		hardButtonText.CrossFadeAlpha(1.0f, 1.0f, false);
		choiceMenuBackButton.CrossFadeAlpha(1.0f, 1.0f, false);
		choiceMenuBackButtonText.CrossFadeAlpha(1.0f, 1.0f, false);
	}

	public void AboutFadeInScreen() {
		aboutMenuBackButton.gameObject.SetActive(true);
		startButton.CrossFadeAlpha(0.0f, 1.0f, false);
		muteButton.CrossFadeAlpha(0.0f, 1.0f, false);
		aboutButton.CrossFadeAlpha(0.0f, 1.0f, false);
		startText.CrossFadeAlpha(0.0f, 1.0f, false);
		muteText.CrossFadeAlpha(0.0f, 1.0f, false);
		aboutText.CrossFadeAlpha(0.0f, 1.0f, false);
		startButton.gameObject.SetActive(false);
		muteButton.gameObject.SetActive(false);
		aboutButton.gameObject.SetActive(false);

		jobTitle1.CrossFadeAlpha(1.0f, 1.0f, false);
		name1.CrossFadeAlpha(1.0f, 1.0f, false);
		jobTitle2.CrossFadeAlpha(1.0f, 1.0f, false);
		name2.CrossFadeAlpha(1.0f, 1.0f, false);
		aboutMenuBackButton.CrossFadeAlpha(1.0f, 1.0f, false);
	}

	public void AboutFadeOutScreen() {
		startButton.gameObject.SetActive(true);
		muteButton.gameObject.SetActive(true);
		aboutButton.gameObject.SetActive(true);

		logo.CrossFadeAlpha(1.0f, 1.0f, false);
		startButton.CrossFadeAlpha(1.0f, 1.0f, false);
		muteButton.CrossFadeAlpha(1.0f, 1.0f, false);
		aboutButton.CrossFadeAlpha(1.0f, 1.0f, false);
		startText.CrossFadeAlpha(1.0f, 1.0f, false);
		muteText.CrossFadeAlpha(1.0f, 1.0f, false);
		aboutText.CrossFadeAlpha(1.0f, 1.0f, false);


		jobTitle1.CrossFadeAlpha(0.0f, 1.0f, false);
		name1.CrossFadeAlpha(0.0f, 1.0f, false);
		jobTitle2.CrossFadeAlpha(0.0f, 1.0f, false);
		name2.CrossFadeAlpha(0.0f, 1.0f, false);
		aboutMenuBackButton.CrossFadeAlpha(0.0f, 1.0f, false);
		aboutMenuBackButton.gameObject.SetActive(false);
	}

    public void SwitchLevel() {
        Application.LoadLevel(1);
    }

	public void MuteSound() {
		if (!muted) {
			muteButton.color = new Color(1f, 0f, 0f);
			muteText.color = new Color(1f, 0f, 0f);
			muteText.text = "Muted";
			muted = true;
		}
		else {
			muteButton.color = new Color(1f, 1f, 1f);
			muteText.color = new Color(1f, 1f, 1f);
			muteText.text = "Mute";
			muted = false;
		}
	}

	private void EnableStartMenu() {
		startButton.gameObject.SetActive(true);
		aboutButton.gameObject.SetActive(true);
		muteButton.gameObject.SetActive(true);
		startButton.color = Color.clear;
		aboutButton.color = Color.clear;
		muteButton.color = Color.clear;
	}

	private void DisableStartMenu() {
		startButton.gameObject.SetActive(false);
		aboutButton.gameObject.SetActive(false);
		muteButton.gameObject.SetActive(false);
	}

	private void EnableAboutMenu() {
		aboutMenuBackButton.gameObject.SetActive(true);
		aboutMenuBackButton.color = Color.clear;
	}

	private void DisableAboutMenu() {
		aboutMenuBackButton.gameObject.SetActive(false);
	}

	private void EnableChoiceMenu() {
		choiceMenuBackButton.gameObject.SetActive(true);
		choiceMenuBackButton.color = Color.clear;
	}

	private void DisableChoiceMenu() {
		choiceMenuBackButton.gameObject.SetActive(false);
	}

	public void SwitchLevel() {
		Application.LoadLevel(1);
	}
}
