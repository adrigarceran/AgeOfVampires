using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class ControlMinijuego : MonoBehaviour {

	[SerializeField]
	private Button b1,b2,b3,b4 = null;

	private bool b1p, b2p, b3p, b4p;

	[SerializeField]
	private AudioSource sonidoclick;
	[SerializeField]
	private AudioSource sonidoNo;
	[SerializeField]
	private AudioSource sonidoFin;

	[SerializeField]
	private GameObject panel;

	[SerializeField]
	private GameObject personaje;

	[SerializeField]
	private Text textoFin;


	// Use this for initialization
	void Start () {
		b1.interactable = true;
		b2.interactable = true;
		b3.interactable = true;
		b4.interactable = true;
		b1p=false; 
		b2p=false;
		b3p=false; 
		b4p=false;
	}


	public void b1pulsado(){
		if (b2p && !b1p && !b3p && !b4p) {
			b1p = true;
			b1.interactable = false;
			sonidoclick.PlayOneShot (sonidoclick.clip);


		}
		else{
			sonidoNo.PlayOneShot (sonidoNo.clip);

			b1.interactable = true;
			b2.interactable = true;
			b3.interactable = true;
			b4.interactable = true;
			b1p = false;
			b2p = false;
			b3p = false;
			b4p = false;
		}
	}
	public void b2pulsado(){
		if (!b1p && !b2p && !b3p && !b4p) {
			b2p = true;
			b2.interactable = false;
			sonidoclick.PlayOneShot (sonidoclick.clip);
		}
		else{
			sonidoNo.PlayOneShot (sonidoNo.clip);

			b1.interactable = true;
			b2.interactable = true;
			b3.interactable = true;
			b4.interactable = true;
			b1p = false;
			b2p = false;
			b3p = false;
			b4p = false;
		}
	}
	public void b3pulsado(){
		if (b1p && b2p && !b3p && b4p) {
			b3.interactable = false;
			b3p = true;
			sonidoFin.PlayOneShot (sonidoFin.clip);
			//sonidoclick.PlayOneShot (sonidoclick.clip);
			conseguido ();

		}
		else{
			sonidoNo.PlayOneShot (sonidoNo.clip);

			b1.interactable = true;
			b2.interactable = true;
			b3.interactable = true;
			b4.interactable = true;
			b1p = false;
			b2p = false;
			b3p = false;
			b4p = false;
		}
	}
	public void b4pulsado(){
		if (b1p && b2p && !b4p && !b3p) {
			b4.interactable = false;
			b4p = true;
			sonidoclick.PlayOneShot (sonidoclick.clip);

		}
		else{
			sonidoNo.PlayOneShot (sonidoNo.clip);

			b1.interactable = true;
			b2.interactable = true;
			b3.interactable = true;
			b4.interactable = true;
			b1p = false;
			b2p = false;
			b3p = false;
			b4p = false;
		}
	}

	public void reiniciar(){
		sonidoNo.PlayOneShot (sonidoNo.clip);

		b1.interactable = true;
		b2.interactable = true;
		b3.interactable = true;
		b4.interactable = true;
		b1p = false;
		b2p = false;
		b3p = false;
		b4p = false;
	}

	public void salir(){
		sonidoNo.PlayOneShot (sonidoNo.clip);

		b1.interactable = true;
		b2.interactable = true;
		b3.interactable = true;
		b4.interactable = true;
		b1p = false;
		b2p = false;
		b3p = false;
		b4p = false;
		personaje.GetComponent<Animator> ().enabled = true;
		personaje.GetComponent<MovimientoPersonaje> ().enabled = true;
		personaje.GetComponent<SmoothMouseLook> ().sensitivityX = 1;
	}
		
	public void conseguido(){
		panel.SetActive (false);
		control.juegoCompletado = true;
		textoFin.gameObject.SetActive (true);
		Invoke ("EscenaBiblio", 2f);
	}

	public void EscenaBiblio(){
		SceneManager.LoadScene ("Biblio");
	}
}
