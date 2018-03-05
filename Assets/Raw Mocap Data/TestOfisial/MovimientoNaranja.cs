using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNaranja : MonoBehaviour {
	static Animator anim;
	[SerializeField]
	private float vel;
	private bool jumping=false;
	public Rigidbody rb;
	public bool grounded=true;
	private int m_VelSalto = 180;


	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		RaycastHit m_Golpe;
		Vector3 physicsCentre = this.transform.position + this.GetComponent<CapsuleCollider> ().center;
		Debug.DrawRay (physicsCentre, Vector3.down * 0.9f, Color.green, 1);
		if(Physics.Raycast(physicsCentre,Vector3.down, out m_Golpe,0.9f))		{
			if (m_Golpe.transform.gameObject.tag != "Player") {
				grounded = true;
			}
		} else 
		{
			grounded = false;
		}
		Debug.Log (grounded);

		if (Input.GetKey (KeyCode.W)) {
			anim.SetBool ("Walk", true);
			transform.Translate (Vector3.forward * vel * Time.deltaTime);
		} else {
			anim.SetBool ("Walk", false);
		}

		if (Input.GetKey (KeyCode.W) && Input.GetKey(KeyCode.LeftShift)) {
			anim.SetBool ("Run", true);
			transform.Translate (Vector3.forward * (vel*2)* Time.deltaTime);
		} else {
			anim.SetBool ("Run", false);
		}

		if (Input.GetKey (KeyCode.S)) {
			anim.SetBool ("Back", true);
			transform.Translate (Vector3.back * vel * Time.deltaTime);
		} else {
			anim.SetBool ("Back", false);
		}

		if (Input.GetKey (KeyCode.A)) {
			anim.SetBool ("Left", true);
			transform.Translate (Vector3.left * vel * Time.deltaTime);
		} else {
			anim.SetBool ("Left", false);
		}

		if (Input.GetKey (KeyCode.D)) {
			anim.SetBool ("Right", true);
			transform.Translate (Vector3.right * vel * Time.deltaTime);
		} else {
			anim.SetBool ("Right", false);
		}

		if (Input.GetKeyDown (KeyCode.Space) && grounded) {
			anim.SetBool ("Jump 0", true);
			this.GetComponent<Rigidbody> ().AddForce (Vector3.up * m_VelSalto);

		} else {
			anim.SetBool ("Jump 0", false);
		}

		if (Input.GetKey(KeyCode.W) && Input.GetKeyDown(KeyCode.Space) && grounded) {
			anim.SetBool ("Jump 1", true);
			transform.Translate (Vector3.forward * vel * Time.deltaTime);
		} else {
			anim.SetBool ("Jump 1", false);
		}

		if (Input.GetKey(KeyCode.W) && Input.GetKeyDown(KeyCode.Space) && grounded && Input.GetKey(KeyCode.LeftShift)) {
			anim.SetBool ("Jump 2", true);
			transform.Translate (Vector3.forward * (vel*2) * Time.deltaTime);
		} else {
			anim.SetBool ("Jump 2", false);
		}
		
	}
}
