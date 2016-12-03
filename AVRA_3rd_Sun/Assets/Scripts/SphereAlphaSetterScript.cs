using UnityEngine;
using System.Collections;

public class SphereAlphaSetterScript : MonoBehaviour {

	LavaSphereScript lavaSphere;
	WaterSphereScript waterSphere;
	ChargeableScript chargeable;

	// Use this for initialization
	void Start () {
		lavaSphere = transform.GetChild(3).GetComponent<LavaSphereScript>();
		waterSphere = transform.GetChild(4).GetComponent<WaterSphereScript>();
		chargeable = transform.GetComponentInChildren<ChargeableScript>();

	}
	
	// Update is called once per frame
	void Update () {
		if (chargeable.temperature > 50f) {
			float lavaToSet = (chargeable.temperature - 50f) / 50f;
			waterSphere.SetMaterialAlpha(0f);
			lavaSphere.SetMaterialAlpha(Mathf.Pow(lavaToSet, 3));
		}
		else if (chargeable.temperature < 50f) {
			float iceToSet = (50f - chargeable.temperature)/ 50f;
			waterSphere.SetMaterialAlpha(Mathf.Pow(iceToSet, 3));
			lavaSphere.SetMaterialAlpha(0f);
		}
		else {
			waterSphere.SetMaterialAlpha(0f);
			lavaSphere.SetMaterialAlpha(0f);
		}
			
			
	}
}
