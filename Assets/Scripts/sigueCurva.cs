using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sigueCurva : MonoBehaviour {
	[SerializeField]
	private float v1,v2,v3;
	private float t, s;
	[SerializeField]
	private float dt;
	private float a;
	private float b;

	private LineRenderer lineas;
	private int numPuntos=100;
	private	float r=0.3f;

	// Use this for initialization
	public void Start () {
		t = 0;
		a = 0; 
		b = Mathf.PI * 2;


		lineas = GetComponent<LineRenderer> ();

		lineas.positionCount = numPuntos+1;
		for (int i = 0; i < lineas.positionCount; i++) {
			lineas.SetPosition (i,f(a+(b-a)*1.0f*i/numPuntos));
		}


	}

	// Update is called once per frame
	public void Update () {
		t += dt;
		s = a + t * (b - a);
		transform.position = f (t);
		Vector3 u = f (t + 0.01f) - f (t);
		Quaternion rot = Quaternion.LookRotation (u, Vector3.up);
		transform.rotation = rot;
		//Quaternion rot = Quaternion. (u, Vector3.up);
	}

	public Vector3 f(float s){
		//float rad=12*Mathf.Cos(s)*Mathf.Sin(s)*Mathf.Sin(s);
		//float rad=12*Mathf.Pow(Mathf.Cos(s/3),3);
		float rad=17;
		//float rad=12*Mathf.Cos(s)*(4*Mathf.Sin(s)*Mathf.Sin(s)-1);
		return rad*new Vector3 (Mathf.Cos(s)+v1,(0.5f/rad)+v2,Mathf.Sin(s)+v3);}
}
