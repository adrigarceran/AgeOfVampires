using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPuertaPatio : MonoBehaviour {

	private bool dentro;

	//Texto de pulsar F para abrir
	[SerializeField]
	private GameObject textoAbrir;

	//personaje principal, se usa para parar las animaciones y el movimiento
	[SerializeField]
	private GameObject personaje;

	//Texto que indica que hay un mecanismo
	[SerializeField]
	private GameObject textoMecanismo;

	//Texto de advertencia
	[SerializeField]
	private GameObject textoAdvertencia;

	//variable que indica si aun estamos en modo advertencia
	private bool textoAdvActivo;

	//variable que indica hemos pulsado
	private bool pulsado;

	//panel usado para el minijuego
	[SerializeField]
	private GameObject panel;

	// Use this for initialization
	void Start () {
		textoAdvActivo = false;
		dentro = false;
		textoMecanismo.SetActive (false);
		textoAbrir.SetActive (false);
		textoAdvertencia.SetActive (false);


	}


	void OnTriggerEnter(){
		dentro = true;
	}

	void OnTriggerExit(){
		dentro = false;
		textoAbrir.SetActive(false);
	}


	void Update () {
		if (dentro && !textoAdvActivo && !pulsado){
			textoAbrir.SetActive (true);
			if (Input.GetKey (KeyCode.F)) {
				if (!control.enemigoVivo) {
					textoAbrir.SetActive (false);
					textoMecanismo.SetActive (true);
					personaje.GetComponent<MovimientoNaranja> ().enabled = false;
					personaje.GetComponent<Animator> ().enabled = false;
					personaje.GetComponent<SmoothMouseLook> ().sensitivityX = 0;
					pulsado = true;
					Invoke ("quitarTexto", 2f);
				} else {
					textoAdvActivo=true;
					textoAbrir.SetActive (false);
					textoAdvertencia.SetActive (true);
					Invoke ("quitaAdvertencia", 3f);
				}
			}
		}
	}
	void quitarTexto(){
		textoMecanismo.SetActive (false);
		panel.SetActive (true);
	}

	void quitaAdvertencia(){
		textoAdvActivo = false;
		textoAdvertencia.SetActive (false);
	}


}
