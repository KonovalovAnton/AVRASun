using UnityEngine;
using System.Collections;

public class PlanetRotationScript : MonoBehaviour {

	public float angle = 90f;

	// Dummy camera old name – VR_UI_dummyCamera

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(transform.position, Vector3.up, Time.deltaTime * angle);
	}
}
