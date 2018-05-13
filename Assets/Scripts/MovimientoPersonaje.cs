using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour {
	static Animator anim;
	[SerializeField]
	private float vel;
	private bool jumping=false;
	private bool walkForward = false;
	private bool walkBack = false;
	private bool walkLeft = false;
	private bool walkRight = false;
	private bool run = false;
	private bool jump1 = false;
	private bool jump2= false;
	private Rigidbody rb;
	public bool grounded=true;


	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		//Esto estaba preaparado para que el personaje pudiera saltar, pero finalmente hemos decicido eliminarlo
		//ya que no aportaba mucho a la jugabilidad pero nos parecia interesante dejarlo aunque sea comentado

		/*RaycastHit m_Golpe;
		Vector3 physicsCentre = this.transform.position + this.GetComponent<CapsuleCollider> ().center;
		Debug.DrawRay (physicsCentre, Vector3.down * 0.9f, Color.green, 1);
		if(Physics.Raycast(physicsCentre,Vector3.down, out m_Golpe,1f))		{
			if (m_Golpe.transform.gameObject.tag != "Player") {
				grounded = true;
			}
		} else 
		{
			grounded = false;
		}*/

		if (Input.GetKey (KeyCode.W)) {
			walkForward = true;
			anim.SetBool ("Walk", true);
			transform.Translate (Vector3.forward * vel * Time.deltaTime);
		} else {
			anim.SetBool ("Walk", false);
			walkForward = false;
		}

		if (Input.GetKey (KeyCode.W) && Input.GetKey(KeyCode.LeftShift)) {
			run = true;
			anim.SetBool ("Run", true);
			transform.Translate (Vector3.forward * (vel*2)* Time.deltaTime);
		} else {
			anim.SetBool ("Run", false);
			run = false;
		}

		if (Input.GetKey (KeyCode.S)) {
			walkBack = true;
			anim.SetBool ("Back", true);
			transform.Translate (Vector3.back * vel * Time.deltaTime);
		} else {
			anim.SetBool ("Back", false);
			walkBack = false;
		}

		if (Input.GetKey (KeyCode.A)) {
			walkLeft = true;
			anim.SetBool ("Left", true);
			transform.Translate (Vector3.left * vel * Time.deltaTime);
		} else {
			anim.SetBool ("Left", false);
			walkLeft = false;
		}

		if (Input.GetKey (KeyCode.D)) {
			walkRight = true;
			anim.SetBool ("Right", true);
			transform.Translate (Vector3.right * vel * Time.deltaTime);
		} else {
			anim.SetBool ("Right", false);
			walkRight = false;
		}

		//Esta parte del codigo hacia la funcion de los distintos saltos
		/*
		if (Input.GetKeyDown (KeyCode.Space) && grounded && !walkLeft && !walkBack && !walkRight) {
			anim.SetBool ("Jump 0", true);
			this.GetComponent<Rigidbody> ().AddForce (Vector3.up * m_VelSalto);

		} else {
			anim.SetBool ("Jump 0", false);
		}

		if (Input.GetKey(KeyCode.W) && Input.GetKeyDown(KeyCode.Space) && grounded && Input.GetKey(KeyCode.LeftShift) && !walkLeft && !walkBack && !walkRight && !jump2 && !jump1) {
			Debug.LogWarning ("SALTO CORRIENDO");
			jump2 = true;
			anim.SetBool ("Jump 2", true);
			transform.Translate (Vector3.forward * (vel*4) * Time.deltaTime);
		} else {
			anim.SetBool ("Jump 2", false);
			jump2 = false;
		}

		if (Input.GetKey(KeyCode.W) && Input.GetKeyDown(KeyCode.Space) && grounded && !jump2) {
			anim.SetBool ("Jump 1", true);
			transform.Translate (Vector3.forward * (vel*2) * Time.deltaTime);
		} else {
			anim.SetBool ("Jump 1", false);
		}*/


		
	}
}
