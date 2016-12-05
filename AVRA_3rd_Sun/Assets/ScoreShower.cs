using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreShower : MonoBehaviour {

    Text t;
	public float time = 120;
	// Use this for initialization
	void Start () {
        t = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			Application.LoadLevel(0);
		}
		ChargeableScript.playTime += Time.deltaTime;
		if((time - (int)(ChargeableScript.playTime)>0) && !ChargeableScript.gameover)
		{
			t.text = "Score: " + (int)ChargeableScript.score + " Time: " + (time - (int)(ChargeableScript.playTime));
		}
		else
		{
			ChargeableScript.gameover = true;
			t.text = "Game Over! Your score: " + ChargeableScript.score;
		}
	}
}
