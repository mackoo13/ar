using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class q : MonoBehaviour {
	public float start_x = 0.0f;
	public float start_y = 8.2f;
	public float start_z = 8.2f;
	
	Rigidbody rb;
	public bool falling;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		falling = false;
		//transform.localPosition = new Vector3(start_x, start_y, start_z);
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
			transform.localPosition = new Vector3(Mathf.Sin(t*2) * 5, transform.localPosition[1], transform.localPosition[2]);
		}
	}

}
