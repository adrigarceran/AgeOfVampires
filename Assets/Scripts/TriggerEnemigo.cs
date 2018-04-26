using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnemigo : MonoBehaviour {
	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			control.enemigoActivo = true;
			this.gameObject.SetActive (false);
		}
	}
}
