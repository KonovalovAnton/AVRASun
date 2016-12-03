using UnityEngine;
using System.Collections;

public class ChargeableScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Charge() {
		Renderer rend = GetComponent<Renderer>();
		rend.material.shader = Shader.Find("Specular");
		rend.material.SetColor("_SpecColor", Color.red);
	}

	public void Uncharge() {
		
	}
}
