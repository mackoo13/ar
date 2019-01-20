using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class q : MonoBehaviour {
	
	Rigidbody rb;
	public bool falling;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		falling = false;
	}
	

	public void Fall(){
		print("FALLING!");
		falling = true;
		rb.useGravity = true;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(!falling) {
			float t = Time.realtimeSinceStartup;
			transform.localPosition = new Vector3(Mathf.Sin(t*2) * 13, transform.localPosition[1], transform.localPosition[2]);
		}
	}

}
