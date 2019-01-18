using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class main : MonoBehaviour {

	public GameObject multiTarget;
	public GameObject plane;
	public InputHelper inputHelper;
	public List<Touch> touches;
	

	// Use this for initialization
	void Start () {
		
		inputHelper = new InputHelper();

		GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>() ;
		foreach(GameObject obj in allObjects){
			print("TEST:\t" + obj.name)  ;
		}
		 plane = GameObject.Find("Plane");
		 print("Plane kids:\t" + plane.transform.childCount);
		 
		 
		 
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

				//make all plane children fall
				foreach (Transform child in plane.transform){
					print(child.transform);
					print(child.parent);
					
					
				}
				
			}
		}
	}
}
