using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour {
	static Animator anim;
	[SerializeField]
	private Transform target;
	[SerializeField]
	private float v, vg;
	Vector3 velocidad;
	bool temporizadorActivo = false;
	[SerializeField]
	int tiempoPerseguir;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();		
	}
	
	// Update is called once per frame
	void Update () {
		if(control.enemigoActivo)
			seguir ();
	}

	void seguir(){
		if (!temporizadorActivo) {
			Invoke ("morirse", tiempoPerseguir);
			temporizadorActivo = true;
		}
		transform.LookAt (target);
		anim.SetBool ("Walk", true);
		transform.Translate (Vector3.forward * v * Time.deltaTime);
	}

	void morirse(){
		control.enemigoActivo = false;
		anim.SetBool ("Walk", false);
		anim.SetBool ("death", true);
		Physics.IgnoreCollision (GetComponent<Collider> (), target.GetComponent<Collider> ());
	}
}
