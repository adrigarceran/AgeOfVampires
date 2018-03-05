using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatforms : MonoBehaviour {
	
	[SerializeField]
	private Transform movingPlatform, position1, position2;
	[SerializeField]
	private Vector3 newPosition;
	[SerializeField]
	private string currentState;
	[SerializeField]
	private float smooth, resetTime;

	// Use this for initialization
	void Start () {
		ChangeState ();
	}
	
	// Update is called once per frame
	void Update () {
		movingPlatform.position = Vector3.Lerp (movingPlatform.position, newPosition, smooth * Time.deltaTime);
	}
	void ChangeState(){
		if (currentState == "Moving to 1") {
			currentState = "Moving to 2";
			newPosition = position2.position;
		} else if (currentState == "Moving to 2") {
			currentState = "Moving to 1";
			newPosition = position1.position;
		} else if (currentState == "") {
			currentState = "Moving to 2";
			newPosition = position2.position;
		}
		Invoke ("ChangeState", resetTime);
	}
}
