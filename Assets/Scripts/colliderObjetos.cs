using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colliderObjetos : MonoBehaviour {
	[SerializeField]
	private GameObject obj;

	[SerializeField]
	private Text texto;

	private bool cogido=false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter(){
		if(!cogido)
			texto.gameObject.SetActive (true);
	}

	void OnTriggerStay(){
		if (!cogido) {
			if (Input.GetKeyDown (KeyCode.E)) {
				Debug.Log ("PULSA E");
				obj.GetComponent<interactuaObjeto> ().CogerObjeto ();
				texto.gameObject.SetActive (false);
				cogido = true;
			}
		}
	}

	void OnTriggerExit(){
		texto.gameObject.SetActive(false);
	}


}
