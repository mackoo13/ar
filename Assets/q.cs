using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class q : MonoBehaviour {
	
	Rigidbody rb;
	bool falling;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		falling = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(!falling) {
			float t = Time.realtimeSinceStartup;
			transform.position = new Vector3(Mathf.Sin(t*2) * 5, transform.position[1], transform.position[2]);
		}
		
		foreach(Touch touch in Input.touches) {
			if (touch.phase == TouchPhase.Began) {
				falling = true;
				rb.useGravity = true;
			}
		}
	}
}
