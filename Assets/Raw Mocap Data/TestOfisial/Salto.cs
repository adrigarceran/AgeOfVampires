using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour {
	public Rigidbody rb;
	bool waitActive = false;

	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody> ();

	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		if (Input.GetButtonDown ("Jump")) {
			//StartCoroutine(Espera());
			rb.velocity = new Vector3 (0, 4, 0);

		}
	}
	//IEnumerator Espera(){
	//	while (true)
	//		yield return new WaitForSeconds(3.0f);
	//}
}
