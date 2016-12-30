using UnityEngine;
using System.Collections;

public class RotateScript : MonoBehaviour {

    Transform centrePoint;
    
    [SerializeField] float angleSpeed;

    void Start () {
        centrePoint = transform.parent;
    }
	
	void Update () {
        transform.RotateAround(centrePoint.position, transform.up, angleSpeed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.parent.position, transform.position);
    }
}
