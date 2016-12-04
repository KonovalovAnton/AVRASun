using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChargeableScript : MonoBehaviour {

    public static float score = 0;
	public static float playTime = 0;
	public static bool gameover = false;

	public float temperature = 50f;
	public float step = 5f;
	float time;
    float scoreStep = 10;

	// Use this for initialization
	void Start () {
		time = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if(!gameover)
		{
			Uncharge();
			GetComponent<Image>().fillAmount = temperature / 100f;

			if (temperature > 100f)
				temperature = 100f;

			if (temperature < 0f)
				temperature = 0f;

	        if (temperature > 45 && temperature < 55)
	        {
	            score += scoreStep* 2 * Time.deltaTime;
	        }
	        else if (temperature > 25 && temperature < 75)
	        {
	            score += scoreStep * Time.deltaTime;
	        }
		}
	}

	public void Charge(float amount) {
		// Change the UI numbers here
		temperature += amount;
	}

	public void Uncharge() {
		temperature -= step * Time.deltaTime;
	}
}
