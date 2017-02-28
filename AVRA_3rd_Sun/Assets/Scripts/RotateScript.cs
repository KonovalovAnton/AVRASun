using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RotateScript : MonoBehaviour {

    Transform centrePoint;
    
    [SerializeField] float angleSpeed;
    [SerializeField] bool registerAsMeteorTarget = true;

    void Start () {
        centrePoint = transform.parent;
        if (registerAsMeteorTarget)
        {
            PlanetHolder.Register(transform);
        }
    }
	
	void Update () {
        transform.RotateAround(centrePoint.position, transform.up, angleSpeed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.parent.position, transform.position);
    }
}

public class PlanetHolder
{
    static List<Transform> planets = new List<Transform>();

    public static bool NotEmpty()
    {
        return planets != null && planets.Count > 0;
    }

    public static Transform GetRandom()
    {
        return planets[Random.Range(0, planets.Count)];
    }

    public static void Register(Transform t)
    {
        planets.Add(t);
    }

    public static void Unregister(Transform t)
    {
        planets.Remove(t);
    }
}
