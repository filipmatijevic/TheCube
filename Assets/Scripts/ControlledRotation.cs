using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlledRotation : MonoBehaviour {

	public float speed;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.Rotate (Vector3.up, speed);
		
	}
}
