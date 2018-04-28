using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnemigo : MonoBehaviour {
	[SerializeField]
	private GameObject textoHuye;

	[SerializeField]
	private AudioSource sonidoIni;

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			textoHuye.SetActive (true);
			sonidoIni.Play ();
			control.enemigoActivo = true;
			this.gameObject.SetActive (false);
			Invoke ("QuitaTexto", 1f);
		}
	}

	public void QuitaTexto(){
		textoHuye.SetActive(false);
	}
}
