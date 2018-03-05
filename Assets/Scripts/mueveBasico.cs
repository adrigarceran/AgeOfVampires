using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mueveBasico : MonoBehaviour {
	public float v, vg;
	float hor, ver;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		hor=Input.GetAxis("Horizontal");
		ver=Input.GetAxis("Vertical");
		transform.Translate(v*ver*transform.forward*Time.deltaTime,Space.World);
		transform.Rotate(vg*hor*Vector3.up*Time.deltaTime, Space.World);
	}
}
