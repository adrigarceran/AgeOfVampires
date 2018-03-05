using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMovimiento : MonoBehaviour {

	public Animator anim;
	[SerializeField]
	private float vel;
	float tiempo=50f;
		
	// Use this for initialization
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			anim.SetBool ("Walk", true);
			transform.Translate (Vector3.forward * vel * Time.deltaTime);
		} else {
			anim.SetBool ("Walk", false);
		}
		if (Input.GetKey (KeyCode.S)) {
			anim.SetBool ("Back", true);
			transform.Translate (Vector3.back * vel * Time.deltaTime);
		} else {
			anim.SetBool ("Back", false);
		}
		if (Input.GetKey (KeyCode.Space)) {
			anim.SetBool ("Jump", true);
			//tiempo = Time.deltaTime;
			//Debug.LogWarning ("TIEMPO: " + tiempo);
			//transform.Translate (Vector3.back * vel * Time.deltaTime);
		} else
			anim.SetBool ("Jump", false);
	}
}
