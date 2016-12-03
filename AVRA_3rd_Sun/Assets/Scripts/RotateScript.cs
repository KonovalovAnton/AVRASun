using UnityEngine;
using System.Collections;

public class RotateScript : MonoBehaviour {

    public Transform centrePoint;
    public float angleSpeed = 1;
    public float direction = 1;


	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(centrePoint.position, transform.up, angleSpeed * Time.deltaTime * direction);
    }
}
