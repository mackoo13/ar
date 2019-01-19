using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour {
	public float start_x = 0.0f;
	public float start_y = 16.0f;
	public float start_z = 0.0f;

	public GameObject multiTarget;
	public GameObject plane;
	//public InputHelper inputHelper;
	public List<Touch> touches;
	public List<Color> colors;
	public Transform box;
	public q current;
	
	public Color GetColor(){
		int currentColor = transform.childCount % colors.Count;
		//return Color.red;
		return colors[currentColor];
	}
	
	public q AddFlyingCube(){
		Transform transformObj = Instantiate(box, new Vector3(start_x, start_y, start_z), Quaternion.identity);
		GameObject clone = transformObj.gameObject;
		q qObj = clone.GetComponent<q>();
		qObj.transform.parent = this.transform;
		qObj.transform.localPosition = new Vector3(start_x, start_y, start_z);
		qObj.GetComponent<Renderer>().material.color = GetColor();
		return qObj;
	}
	

	// Use this for initialization
	void Start () {
		colors = new List<Color>();
		colors.Add(Color.blue);
		colors.Add(Color.cyan);
		colors.Add(Color.green);
		colors.Add(Color.red);
		colors.Add(Color.white);
		colors.Add(Color.yellow);
		
		current = AddFlyingCube(); 
		current.GetComponent<Renderer>().material.color = Color.blue;
		print("Current position:\t"+current.transform.localPosition);
	}
	
	// Update is called once per frame
	void Update () {
#if UNITY_EDITOR
		touches = InputHelper.GetTouches();
#else
		touches = Input.touches;
#endif	
		if(current.falling){
			current = AddFlyingCube();
		}

		foreach(Touch touch in touches) {
			if (touch.phase == TouchPhase.Began) {
				current.Fall();
				//current = AddFlyingCube();					
					
			}
				
		}
	}
	
}
