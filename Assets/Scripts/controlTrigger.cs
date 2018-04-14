 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlTrigger : MonoBehaviour {

	[SerializeField]
	private GameObject textoAbrir;

	[SerializeField]
	private GameObject controlMenu;
		
	[SerializeField]
	private GameObject textoTodos;

	[SerializeField]
	private GameObject textoNoTodos;

	private bool dentro = false;

	void OnTriggerEnter(){
		dentro = true;
		textoAbrir.SetActive (true);
		//Debug.LogWarning ("ENTRA");
	}

	void OnTriggerExit(){
		dentro = false;
		textoAbrir.SetActive(false);
		textoNoTodos.SetActive (false);
		textoTodos.SetActive (false);
	}

	//void OnTriggerStay(){
		
//		if (Input.GetKey (KeyCode.F)) {
//			Debug.LogWarning("PULSADO F");

//		}
//	}
	// Use this for initialization
	void Start () {
		if (controlMenu == null) {
			controlMenu = GameObject.Find ("controlMenu");
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (dentro){
			if (Input.GetKey (KeyCode.F)) {
				Debug.LogWarning("PULSADO F");
				if (control.objetos == 0) {
					textoTodos.SetActive (true);
					Time.timeScale = 0;
					Invoke ("pantallaFinal",2f);
				} else {
					textoNoTodos.SetActive (true);
					textoAbrir.SetActive (false);
					Invoke ("quitarTexto", 2f);

				}
				dentro = false;

			}
		}
	}
	void quitarTexto(){
		textoNoTodos.SetActive(false);
		textoAbrir.SetActive (true);
	}

	void pantallaFinal(){
		SceneManager.LoadScene ("menu");
	}
}
