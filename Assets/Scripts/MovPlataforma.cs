using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlataforma : MonoBehaviour {

	[SerializeField]
	private Vector3 _posIni, _posFin;
	[SerializeField]
	private float duracion=1.0f;
	private float lerp = 0f;

	// Use this for initialization
	void Start () {
		transform.localPosition = _posIni;
	}
	
	// Update is called once per frame
	void Update () {
		lerp = Mathf.PingPong (Time.time, duracion) / duracion;
		transform.localPosition = Vector3.Lerp (_posIni, _posFin, lerp);
		
	}
}
