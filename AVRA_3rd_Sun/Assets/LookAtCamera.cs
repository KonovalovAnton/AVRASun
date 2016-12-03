using UnityEngine;
using System.Collections;

public class LookAtCamera : MonoBehaviour {

    Transform sun;
	// Use this for initialization
	void Start () {
        sun = GameObject.Find("Main Camera").transform;
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation = Quaternion.LookRotation(transform.position - sun.transform.position);
	}
}
