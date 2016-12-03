using UnityEngine;
using System.Collections;

public class RotateScript : MonoBehaviour {

    public Transform centrePoint;
    public float angleSpeed = 1;
    public float direction = 1;
    public GameObject line;
    public float eclipticRotation = 0;


	// Use this for initialization
	void Start () {
        float r = Mathf.Sqrt((transform.position.x - centrePoint.position.x) *
            (transform.position.x - centrePoint.position.x) + (transform.position.z - centrePoint.position.z) *
            (transform.position.z - centrePoint.position.z));
        float x = 0;
        float y = r;
        for (float i = 0; i < Mathf.PI*2; i+=Mathf.PI/90)
        {
			x = Mathf.Cos(i) * r + centrePoint.position.x;
			y = Mathf.Sin(i) * r + centrePoint.position.y;
            GameObject go = GameObject.Instantiate(line, new Vector3(x,0,y), Quaternion.identity) as GameObject;
            go.transform.parent = transform.parent;
        }
        transform.parent.Rotate(new Vector3(0, 0, eclipticRotation));
    }
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(centrePoint.position, transform.up, angleSpeed * Time.deltaTime * direction);
    }
}
