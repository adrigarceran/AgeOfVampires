using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov2 : MonoBehaviour {

	[SerializeField]
	private float _velocidadGiro=1f;

	[SerializeField]
	private float _velocidadMov=0.3f;

	[SerializeField]
	private KeyCode _izquierda=KeyCode.A;
	[SerializeField]
	private KeyCode _derecha=KeyCode.D;
	[SerializeField]
	private KeyCode _delante=KeyCode.W;
	[SerializeField]
	private KeyCode _detras=KeyCode.S;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//izquierda
		if (Input.GetKey(_izquierda)){
			transform.Rotate (_velocidadGiro* Vector3.down);
		}
		//derecha
		if (Input.GetKey(_derecha)){
			transform.Rotate (_velocidadGiro* Vector3.up);

		}

		if (Input.GetKey(_delante)){
			transform.Translate (_velocidadMov* Vector3.forward);

		}

		if (Input.GetKey(_detras)){
			transform.Translate (_velocidadMov* -Vector3.forward);

		}
		
	}
}
