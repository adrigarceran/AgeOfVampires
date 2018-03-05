using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMenu : MonoBehaviour {


	public void Graficos1(){
		QualitySettings.SetQualityLevel(0);
	}
	public void Graficos2(){
		QualitySettings.SetQualityLevel(1);
	}
	public void Graficos3(){
		QualitySettings.SetQualityLevel(2);
	}
	public void Graficos4(){
			QualitySettings.SetQualityLevel(3);
	}
	public void Graficos5(){
			QualitySettings.SetQualityLevel(4);
	}
	public void Graficos6(){
			QualitySettings.SetQualityLevel(5);
	}

	public void salir(){
		Application.Quit ();
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
