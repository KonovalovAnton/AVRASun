using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour {

    [SerializeField] GameObject visuals;
    [SerializeField] float waitTime = 10;
    [SerializeField] float deltaRange = 100;
    [SerializeField] float speed = 200;
    [SerializeField] float lifeTime = 1f;

    Transform target;
    Vector3 start;
    bool moving;
    float timeToLaunch;
    float t;
    float life;

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
            Debug.Log("Planet Destroyed!");
            target.GetComponentInChildren<ChargeableScript>().DischargeFully();
            OnApproach();
            return;
        }
        t += Time.deltaTime;
        transform.Translate((target.position - transform.position).normalized * Time.deltaTime * 
            speed * (1 + (Mathf.Min(10, t) /10)));

    }

    void OnApproach()
    {
        moving = false;
        timeToLaunch = Time.time + waitTime;
        visuals.SetActive(false);
        transform.position = start;
        life = lifeTime;
        t = 0;
    }

    public void HitBySun()
    {
        if(moving)
        {
            life -= Time.deltaTime;
            if(life < 0)
            {
                Debug.Log("Meteor Destroyed!");
                //explosion
                OnApproach();
            }
        }
    }
}
