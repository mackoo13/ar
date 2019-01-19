using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour {
	public float start_x = 0.0f;
	public float start_y = 8.2f;
	public float start_z = 0.0f;

	public GameObject multiTarget;
	public GameObject plane;
	//public InputHelper inputHelper;
	public List<Touch> touches;
	public Transform box;
	public q current;
	
	public q AddFlyingCube(){
		Transform transformObj = Instantiate(box, new Vector3(), Quaternion.identity);
		GameObject clone = transformObj.gameObject;
		q qObj = clone.GetComponent<q>();
		qObj.transform.parent = this.transform;
		qObj.transform.localPosition = new Vector3(start_x, start_y, start_z);
		return qObj;
	}
	

	// Use this for initialization
	void Start () {
		current = AddFlyingCube(); 
		print("Current position:\t"+current.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
#if UNITY_EDITOR
		touches = InputHelper.GetTouches();
#else
		touches = Input.touches;
#endif	

		foreach(Touch touch in touches) {
			if (touch.phase == TouchPhase.Began) {
				current.Fall();
				current = AddFlyingCube();					
					
			}
				
		}
	}
	
}
