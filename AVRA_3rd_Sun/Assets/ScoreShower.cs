﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreShower : MonoBehaviour {

    Text t;
	// Use this for initialization
	void Start () {
        t = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        t.text = "Score: " + (int)ChargeableScript.score;
	}
}
