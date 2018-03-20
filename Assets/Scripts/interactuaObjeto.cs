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

	void OnMouseDown(){
		controlMenu.GetComponent<menusNivel2> ().cambiaMensaje (descripcion);
		Debug.LogWarning ("name: " + name);
		if (name == "Libro") {
			Debug.LogWarning ("HOLIS");
			control.libro = true;
			hazEfecto ();
		}
		if (name == "Cruz") {
			control.cruz = true;
			hazEfecto ();
		}
		if (name == "Gema") {
			control.gema = true;
			hazEfecto ();
		}

		controlMenu.GetComponent<menusNivel2> ().actualizaInventario();
		if (destructible) {
			Destroy (gameObject);
		}
	}

	void hazEfecto(){
		if (control.efectos) {
			GameObject miSonido = Instantiate (sonido);
			miSonido.transform.position = transform.position;
		}
		GameObject miEfecto = Instantiate (efecto);
		miEfecto.transform.position = transform.position;
	}
}
