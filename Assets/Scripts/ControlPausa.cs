using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlPausa : MonoBehaviour {
	public GameObject pausa;
	bool pausaActivado = false;
	[SerializeField]
	private GameObject personaje;

	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape) && !control.personajeMuerto) 
			cambiaPausa ();
	}

	public void cambiaPausa(){
		pausaActivado = !pausaActivado;
		pausa.SetActive (pausaActivado);

		if (control.dt == 0) {
			personaje.GetComponent<Animator> ().enabled = true;
			personaje.GetComponent<MovimientoNaranja> ().enabled = true;
			personaje.GetComponent<SmoothMouseLook> ().sensitivityX = 1;
			control.dt = 1;
		} else {
			personaje.GetComponent<MovimientoNaranja> ().enabled = false;
			personaje.GetComponent<Animator> ().enabled = false;
			personaje.GetComponent<SmoothMouseLook> ().sensitivityX = 0;
			control.dt = 0;
		}
		
		if (Time.timeScale == 1) {
			personaje.GetComponent<MovimientoNaranja> ().enabled = false;
			personaje.GetComponent<Animator> ().enabled = false;
			personaje.GetComponent<SmoothMouseLook> ().sensitivityX = 0;
			Time.timeScale = 0;
		} else {
			personaje.GetComponent<Animator> ().enabled = true;
			personaje.GetComponent<MovimientoNaranja> ().enabled = true;
			personaje.GetComponent<SmoothMouseLook> ().sensitivityX = 1;
			Time.timeScale = 1;
		}
		
	}

	public void salir(){
		cambiaPausa ();
		SceneManager.LoadScene ("EntradaCastillo", LoadSceneMode.Single);
		control.defaultValues ();
	}

	public void continuar(){
		cambiaPausa ();
	}
}