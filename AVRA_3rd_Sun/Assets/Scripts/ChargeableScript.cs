using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChargeableScript : MonoBehaviour {

	public float temperature = 50f;
	public float step = 5f;
	float time;

	// Use this for initialization
	void Start () {
		time = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		Uncharge();
		GetComponent<Image>().fillAmount = temperature / 100f;

		if (temperature > 100f)
			temperature = 100f;

		if (temperature < 0f)
			temperature = 0f;
	}

	public void Charge(float amount) {
		// Change the UI numbers here
		temperature += amount;
	}

	public void Uncharge() {
		temperature -= step * Time.deltaTime;
	}
}
