using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steeringBasico : MonoBehaviour {
	
	[SerializeField]
	private Transform[] posiciones;

	[SerializeField]
	private float v;

	[SerializeField]
	private float d=0.2f;

	[SerializeField]
	private float smooth=0.2f;

	private Vector3 P0, P1;
	private Quaternion rot;
	private int i=0;

	// Use this for initialization
	void Start () {
		calculaPosiciones ();
		orienta ();
		transform.position = P0;
	}
	
	// Update is called once per frame
	void Update () {
		orienta ();
		mueve ();
		comprueba ();
	}

	void calculaPosiciones(){
		P0=posiciones[i].position;
		P1=posiciones[(i+1)%posiciones.Length].position;
	}

	void orienta(){
		rot = Quaternion.LookRotation (P1 - transform.position, Vector3.up);
		transform.rotation = Quaternion.Slerp(transform.rotation,rot,smooth);
	}

	void mueve(){
		transform.position += transform.forward * v * Time.deltaTime;
	}

	void comprueba(){
		if (Vector3.Distance (transform.position, P1) < d) {
			i = (i + 1) % posiciones.Length;
			calculaPosiciones ();
		}
	}
}
