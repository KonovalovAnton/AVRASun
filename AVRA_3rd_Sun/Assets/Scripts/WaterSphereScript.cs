using UnityEngine;
using System.Collections;

public class WaterSphereScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetMaterialAlpha(float value) {
        //stop flooding
		//Debug.Log("Water Sphere Alpha Value: " + value);
		//this.GetComponent<MeshRenderer>().material.color.a =
		this.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, value);
	}
}
