using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menusNivel2 : MonoBehaviour {
	public bool pausaActivado = false;
	public bool mensajeActivado = false;
	public bool opcionesActivado = false;

	public GameObject opciones, pausa, mensaje, sonidoFondo;
	public Text texto;
	public Toggle toggleEfectos;
	public Scrollbar sliderVolume;

	public Image libro, cruz, gema;
	public Sprite libro1, libro2, cruz1, cruz2, gema1, gema2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			cambiaPausa ();}
		if (Input.GetKeyDown (KeyCode.O)) {
			cambiaOpciones ();}
		if (Input.GetKeyDown (KeyCode.T)) {
			cambiaMensaje ("Hola");}
	}

	public void cambiaPausa(){
		if (!mensajeActivado && !opcionesActivado) {
			pausaActivado = !pausaActivado;
			pausa.SetActive (pausaActivado);
			ponDt ();
		}
	}

	public void cambiaOpciones(){
		if (!mensajeActivado && !pausaActivado) {
			opcionesActivado = !opcionesActivado;
			opciones.SetActive (opcionesActivado);
			ponDt();
		}
	}

	public void cambiaMensaje(string miMensaje){
		if (!opcionesActivado && !pausaActivado) {
			mensajeActivado = true;
			texto.text = miMensaje;
			mensaje.SetActive (true);
			Invoke ("quitaMensaje", 2);
		}
	}

	void quitaMensaje(){
		mensajeActivado = false;
		mensaje.SetActive (false);
	}

	void ponDt(){
		if(opcionesActivado || pausaActivado){
			control.dt=0;
		}
		else{
			control.dt=1;
		}
	}

	public void actualizaInventario(){
		if (control.libro) {
			libro.sprite = libro2;
		} else {
			libro.sprite = libro1;
		}

		if (control.gema) {
			gema.sprite = gema2;
		} else {
			gema.sprite = gema1;
		}

		if (control.cruz) {
			cruz.sprite = cruz2;
		} else {
			cruz.sprite = cruz1;
		}
	}

	public void cambiaEfectos(){
		control.efectos = toggleEfectos.isOn;
	}

	public void salir(){
		Application.Quit ();}

	public void ponVolume(){
		sonidoFondo.GetComponent<AudioSource> ().volume = sliderVolume.value;
	}
}
