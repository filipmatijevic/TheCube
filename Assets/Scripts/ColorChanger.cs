using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour {

	private Renderer cubeColor;
	private Color Color1;
	private Color Color2;
	public float val;

	// Use this for initialization
	void Start () {
		Color1 = Color.red;
		Color2 = Color.blue;

		cubeColor = this.GetComponent<Renderer> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		val += Time.deltaTime;
		cubeColor.material.color = Color.Lerp (Color1, Color2, Mathf.PingPong (val, 1f));
		
	}
}
