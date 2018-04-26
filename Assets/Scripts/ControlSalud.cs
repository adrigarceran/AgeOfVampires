using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSalud : MonoBehaviour {
	int salud = 3;
	float lastHit = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (salud == 0) {
			Debug.LogWarning ("MUERTO");
		}
		
	}

	void OnTriggerEnter(Collider col){
		if (col.name.Equals ("Enemigo") && Time.time - lastHit > 1.5) {
			lastHit = Time.time;
			salud -= 1;
			Debug.LogWarning(salud);
		}
	}

	void OnTriggerStay(Collider col){
		if (col.name.Equals ("Enemigo") && Time.time - lastHit > 1.5) {
			lastHit = Time.time;
			salud -= 1;
			Debug.LogWarning(salud);
		}
	}
}
