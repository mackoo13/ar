﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class r : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Renderer rend = GetComponent<Renderer>();
        rend.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
