﻿using UnityEngine;
using System.Collections;

public class HS : MonoBehaviour {
	public ParticleSystem Hyper;
	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		float speed = 60.0f * Time.deltaTime;
		if (Input.GetKeyDown (KeyCode.DownArrow))
			Hyper.enableEmission = true;
		if (Input.GetKeyUp (KeyCode.DownArrow))
			Hyper.enableEmission = false;
		if (Input.GetKey (KeyCode.DownArrow))
			transform.Translate (-speed, 0.0f, 0.0f);
	}
}

