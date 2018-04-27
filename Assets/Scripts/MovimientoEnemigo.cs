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
	[SerializeField]
	private AudioSource hitmarker;
	[SerializeField]
	private GameObject canvasHitmarker;

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
		Invoke ("playHitmarker", 0.4f);
		Invoke ("activaHitmarker", 0.4f);
		Invoke ("desactivaHitmarker", 0.7f);
		control.enemigoActivo = false;
		anim.SetBool ("Walk", false);
		anim.SetBool ("death", true);
		Physics.IgnoreCollision (GetComponent<Collider> (), target.GetComponent<Collider> ());
		control.enemigoVivo = false;
	}

	void desactivaHitmarker(){
		canvasHitmarker.SetActive (false);
	}

	void activaHitmarker(){
		canvasHitmarker.SetActive (true);
	}

	void playHitmarker(){
		hitmarker.Play ();
	}
}
