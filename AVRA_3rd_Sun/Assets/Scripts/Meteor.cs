using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour {

    [SerializeField] GameObject visuals;
    Transform target;
    Vector3 start;
    bool moving;
    float timeToLaunch;
    float waitTime = 10;
    float deltaRange = 1000;
    float speed = 2000;

	// Use this for initialization
	void Start () {
        start = transform.position;
        OnApproach();
	}
	
	// Update is called once per frame
	void Update () {
		if(moving)
        {
            Fly();
            return;
        }

        if(timeToLaunch < Time.time)
        {
            Launch();
        }
	}

    void Launch()
    {
        if(PlanetHolder.NotEmpty())
        {
            target = PlanetHolder.GetRandom();
            moving = true;
            visuals.SetActive(true);
        }
        else
        {
            OnApproach();
        }
    }

    void Fly()
    {
        if(Vector3.Distance(transform.position,target.position) < deltaRange)
        {
            OnApproach();
            return;
        }

        transform.Translate((target.position - transform.position).normalized * Time.deltaTime * speed);

    }

    void OnApproach()
    {
        moving = false;
        timeToLaunch = Time.time + waitTime;
        visuals.SetActive(false);
        transform.position = start;
    }


}
