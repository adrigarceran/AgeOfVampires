using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSalud : MonoBehaviour {
	int salud = 3;
	float lastHit = 0.0f;
	[SerializeField]
	private GameObject salud2, salud1, muerto;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (salud == 2)
			salud2.SetActive (true);
		else if (salud == 1) {
			salud2.SetActive (false);
			salud1.SetActive (true);
		} else if (salud == 0) {
			salud1.SetActive (false);
			muerto.SetActive (true);
			// Parar juego

			// Capturar espacio y reiniciar

			// Poner cámara en blanco y negro?

			// Desactivar cuando se muera el moñeco

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
