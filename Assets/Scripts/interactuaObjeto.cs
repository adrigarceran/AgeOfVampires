using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactuaObjeto : MonoBehaviour {
	public GameObject controlMenu, sonido, efecto;
	public string descripcion;
	public bool destructible=false;
	// Use this for initialization
	void Start () {
		if (controlMenu == null) {
			controlMenu = GameObject.Find ("controlMenu");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CogerObjeto(){
		if (control.dt == 1) {
			if (name.Equals("LIBRO")) {
				control.libro = true;
				hazEfecto ();
				control.objetos--;
				controlMenu.GetComponent<menusNivel2> ().cambiaMensaje (mensajeObjetos ());
			}
			if (name.Equals("CRUZ")) {
				control.cruz = true;
				hazEfecto ();
				control.objetos--;
				controlMenu.GetComponent<menusNivel2> ().cambiaMensaje (mensajeObjetos ());
			}
			if (name.Equals("GEMA")) {
				control.gema = true;
				hazEfecto ();
				control.objetos--;
				controlMenu.GetComponent<menusNivel2> ().cambiaMensaje (mensajeObjetos ());
			}

			controlMenu.GetComponent<menusNivel2> ().actualizaInventario ();
			if (destructible) {
				Destroy (gameObject);
			}
		}
		Debug.LogWarning (control.dt);
	}

	void hazEfecto(){
		if (control.efectos) {
			GameObject miSonido = Instantiate (sonido);
			miSonido.transform.position = transform.position;
		}
		GameObject miEfecto = Instantiate (efecto);
		miEfecto.transform.position = transform.position;
	}

	string mensajeObjetos(){
		if (control.objetos == 1)
			return "Queda 1 objeto";
		if (control.objetos == 0)
			return "¡Ya tienes todos los objetos!";
			
		return "Quedan " + control.objetos + " objetos";
	}
}
