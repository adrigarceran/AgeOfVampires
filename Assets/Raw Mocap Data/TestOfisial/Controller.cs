using System.Collections;
using UnityEngine;

public class Controller : MonoBehaviour {
	public float m_Vel = 8f;
	public float m_VelRot = 80f;
	public int m_VelSalto = 250;
	public bool grounded=true;

	
	// Update is called once per frame
	void Update ()
	{
		float translation = Input.GetAxis ("Vertical") * m_Vel;
		float rotation = Input.GetAxis ("Horizontal") * m_VelRot;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate (0, 0, translation);
		transform.Rotate (0, rotation, 0);

		RaycastHit m_Golpe;
		Vector3 physicsCentre = this.transform.position + this.GetComponent<CapsuleCollider> ().center;
		Debug.DrawRay (physicsCentre, Vector3.down * 1.2f, Color.green, 1);
		if(Physics.Raycast(physicsCentre,Vector3.down, out m_Golpe,1.2f))		{
			if (m_Golpe.transform.gameObject.tag != "Player") {
				grounded = true;
			}
		} else 
		{
			grounded = false;
		}
		Debug.Log (grounded);
		if (Input.GetKeyDown (KeyCode.Space) && grounded) {
			this.GetComponent<Rigidbody> ().AddForce (Vector3.up * m_VelSalto);
		}
	}
}
