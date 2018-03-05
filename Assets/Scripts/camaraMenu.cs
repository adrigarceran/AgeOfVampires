using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraMenu : MonoBehaviour {
	[SerializeField]
	private Transform target;
	[SerializeField]
	private float velocidad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(target);
		transform.Translate (velocidad * Time.deltaTime * Vector3.right);
	}
}
