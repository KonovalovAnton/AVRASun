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

	bool fadeLogo = false;


	// Working vars
	public Image loadingBar;
	public Image L;
	public Image A;
	public Image D;
	public Image I;
	public Image N;
	public Image G;

	// Use this for initialization
	void Start () {
		muted = false;
		DisableChoiceMenu();
		DisableAboutMenu();
		jobTitle1.color = Color.clear;
		name1.color = Color.clear;
		jobTitle2.color = Color.clear;
		name2.color = Color.clear;
	}
		
	public void PlayButtonCallback() {
		fadeLogo = true;
		StartCoroutine(FadeOutStartMenu());
		StartCoroutine(FadeInChoiceMenu());
	}

	public void AboutButtonCallback() {
		fadeLogo = false;
		StartCoroutine(FadeInAboutMenu());
		StartCoroutine(FadeOutStartMenu());
	}

	public void ChoiceMenuBackButtonCallback() {
		StartCoroutine(FadeOutChoiceMenu());
		StartCoroutine(FadeInStartMenu());
	}

	public void AboutMenuBackButtonCallback() {
		StartCoroutine(FadeOutAboutMenu());
		StartCoroutine(FadeInStartMenu());
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

		if (!muted) {
			muteButton.color = Color.clear;
		}
		else {
			muteButton.color = new Color(1f, 0f, 0f, 0f);
			//muteButton.color = Color.red;
		}
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
		easyButton.gameObject.SetActive(true);
		normalButton.gameObject.SetActive(true);
		hardButton.gameObject.SetActive(true);
		choiceMenuBackButton.gameObject.SetActive(true);
		easyButton.color = Color.clear;
		normalButton.color = Color.clear;
		hardButton.color = Color.clear;
		choiceMenuBackButton.color = Color.clear;
	}

	private void DisableChoiceMenu() {
		easyButton.gameObject.SetActive(false);
		normalButton.gameObject.SetActive(false);
		hardButton.gameObject.SetActive(false);
		choiceMenuBackButton.gameObject.SetActive(false);
	}

	IEnumerator FadeOutStartMenu() {
		for (float alpha = 1.0f; alpha > 0f; alpha -= Time.deltaTime) {
			Color temp = new Color(logo.color.r, logo.color.g, logo.color.b, alpha);
			if (fadeLogo) {
				logo.color = temp;
			}
			startButton.color = temp;
			//muteButton.color = new Color(muteButton.color.r, muteButton.color.g, muteButton.color.b, alpha); // ugly fast fix
			aboutButton.color = temp;
			startText.color = temp;
			//muteText.color = new Color(muteButton.color.r, muteButton.color.g, muteButton.color.b, alpha);
			aboutText.color = temp;
			if (!muted) {
				muteButton.color = new Color(1, 1, 1, alpha);
				muteText.color = new Color(1, 1, 1, alpha);
			}
			else {
				muteButton.color = new Color(1, 0, 0, alpha);
				muteText.color = new Color(1, 0, 0, alpha);
			}
			yield return null;
		}
		DisableStartMenu();
	}

	IEnumerator FadeInStartMenu() {
		EnableStartMenu();
		for (float alpha = 0.0f; alpha < 1.0f; alpha += Time.deltaTime / 2) {
			Color temp = new Color(logo.color.r, logo.color.g, logo.color.b, alpha);
			if (fadeLogo) {
				logo.color = temp;
			}
			startButton.color = temp;
			aboutButton.color = temp;
			startText.color = temp;
			aboutText.color = temp;
			if (!muted) {
				muteButton.color = new Color(1, 1, 1, alpha);
				muteText.color = new Color(1, 1, 1, alpha);
			}
			else {
				muteButton.color = new Color(1, 0, 0, alpha);
				muteText.color = new Color(1, 0, 0, alpha);
			}
			yield return null;
		}
	}

	IEnumerator FadeOutChoiceMenu() {
		for (float alpha = 1.0f; alpha > 0.0f; alpha -= Time.deltaTime) {
			Color temp = new Color(logo.color.r, logo.color.g, logo.color.b, alpha);
			easyButton.color = temp;
			easyButtonImage.color = temp;
			easyButtonText.color = temp;
			normalButton.color = temp;
			normalButtonImage.color = temp;
			normalButtonText.color = temp;
			hardButton.color = temp;
			hardButtonImage.color = temp;
			hardButtonText.color = temp;
			choiceMenuBackButton.color = temp;
			choiceMenuBackButtonText.color = temp;
			yield return null;
		}
		DisableChoiceMenu();
	}

	IEnumerator FadeInChoiceMenu() {
		EnableChoiceMenu();
		for (float alpha = 0.0f; alpha < 1.0f; alpha += Time.deltaTime / 2) {
			Color temp = new Color(logo.color.r, logo.color.g, logo.color.b, alpha);
			easyButton.color = temp;
			easyButtonImage.color = temp;
			easyButtonText.color = temp;
			normalButton.color = temp;
			normalButtonImage.color = temp;
			normalButtonText.color = temp;
			hardButton.color = temp;
			hardButtonImage.color = temp;
			hardButtonText.color = temp;
			choiceMenuBackButton.color = temp;
			choiceMenuBackButtonText.color = temp;
			yield return null;
		}
	}

	IEnumerator FadeOutAboutMenu() {
		for (float alpha = 1.0f; alpha > 0.0f; alpha -= Time.deltaTime) {
			Color temp = new Color(logo.color.r, logo.color.g, logo.color.b, alpha);
			jobTitle1.color = temp;
			name1.color = temp;
			jobTitle2.color = temp;
			name2.color = temp;
			aboutMenuBackButton.color = temp;
			aboutMenuBackButtonText.color = temp;
			yield return null;
		}
		DisableAboutMenu();
	}

	IEnumerator FadeInAboutMenu() {
		EnableAboutMenu();
		for (float alpha = 0.0f; alpha < 1.0f; alpha += Time.deltaTime / 2) {
			Color temp = new Color(logo.color.r, logo.color.g, logo.color.b, alpha);
			jobTitle1.color = temp;
			name1.color = temp;
			jobTitle2.color = temp;
			name2.color = temp;
			aboutMenuBackButton.color = temp;
			aboutMenuBackButtonText.color = temp;
			yield return null;
		}
	}

	private Vector3 zAxis = new Vector3(0, 0, 1);

	void Update() {
//		L.transform.RotateAround(loadingBar.transform.position, zAxis, 1f);
//		L.transform.eulerAngles = new Vector3(0, 0, 0);
//		A.transform.RotateAround(loadingBar.transform.position, zAxis, 1.25f);
//		A.transform.eulerAngles = new Vector3(0, 0, 0);
//		D.transform.RotateAround(loadingBar.transform.position, zAxis, 5f);
//		D.transform.eulerAngles = new Vector3(0, 0, 0);
//		I.transform.RotateAround(loadingBar.transform.position, zAxis, 0.75f);
//		I.transform.eulerAngles = new Vector3(0, 0, 0);
//		N.transform.RotateAround(loadingBar.transform.position, zAxis, 0.5f);
//		N.transform.eulerAngles = new Vector3(0, 0, 0);
//		G.transform.RotateAround(loadingBar.transform.position, zAxis, 1.75f);
//		G.transform.eulerAngles = new Vector3(0, 0, 0);

		// ASK ABOUT FACING TOWARDS FACE SCRIPT

//		logo.transform.RotateAround(startButton.transform.position, zAxis, 1f); 
//		logo.transform.eulerAngles = new Vector3(0, 0, 0);
	}
}
