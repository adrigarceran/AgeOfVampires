﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControlMensajes : MonoBehaviour {
	[SerializeField]
	private GameObject MensajeInicio;
	[SerializeField]
	private GameObject personaje;

	// Use this for initialization
	void Start () {
		personaje.GetComponent<MovimientoPersonaje> ().enabled = false;
		personaje.GetComponent<Animator> ().enabled = false;
		personaje.GetComponent<SmoothMouseLook> ().sensitivityX = 0;
		MensajeInicio.SetActive (true);
		Invoke ("QuitarMsgInicio", 5f);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void QuitarMsgInicio(){

		personaje.GetComponent<Animator> ().enabled = true;
		personaje.GetComponent<MovimientoPersonaje> ().enabled = true;
		personaje.GetComponent<SmoothMouseLook> ().sensitivityX = 1;
		MensajeInicio.SetActive (false);
	}

}
