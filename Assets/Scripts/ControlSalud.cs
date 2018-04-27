using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlSalud : MonoBehaviour {
	int salud = 3;
	float lastHit = 0.0f;
	[SerializeField]
	private GameObject salud2, salud1, muerto;
	[SerializeField]
	private AudioSource damage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!control.enemigoVivo) {
			salud2.SetActive (false);
			salud1.SetActive (false);
			muerto.SetActive (false);
		}else if (salud == 2)
			salud2.SetActive (true);
		else if (salud == 1) {
			salud2.SetActive (false);
			salud1.SetActive (true);
		} else if (salud == 0) {
			salud1.SetActive (false);
			muerto.SetActive (true);
			// Parar juego
			control.dt = 1;
			Time.timeScale = 0;
			// Capturar espacio y reiniciar
			if (Input.GetKeyDown (KeyCode.Escape)) 
				SceneManager.LoadScene ("JuegoPArte1", LoadSceneMode.Single);
			// Poner cámara en blanco y negro?


			Debug.LogWarning ("MUERTO");
		}

		
	}

	void OnTriggerEnter(Collider col){
		if (col.name.Equals ("Enemigo") && Time.time - lastHit > 1.5 && salud > 0 && control.enemigoVivo) {
			lastHit = Time.time;
			damage.Play ();
			salud -= 1;
			Debug.LogWarning(salud);
		}
	}

	void OnTriggerStay(Collider col){
		if (col.name.Equals ("Enemigo") && Time.time - lastHit > 1.5 && salud > 0 && control.enemigoVivo) {
			lastHit = Time.time;
			damage.Play ();
			salud -= 1;
			Debug.LogWarning(salud);
		}
	}
}
