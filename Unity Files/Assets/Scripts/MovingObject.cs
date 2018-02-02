using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour {
	//Floats for Variables
	public float min=2f;
	public float max=3f;
	// Use this for initialization
	void Start () {
		min=transform.position.x;
		//Change Number on next line to change distance covered
		//Each tile in game equals around 2.5
		max=transform.position.x+10;
	}
	
	// Update is called once per frame
	void Update () {
		//Change Number next to Time.time to increase speed
		transform.position =new Vector3(Mathf.PingPong(Time.time*2,max-min)+min, transform.position.y, transform.position.z);
	}
}
