using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlPausa : MonoBehaviour {
	public GameObject pausa;
	bool pausaActivado = false;

	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) 
			cambiaPausa ();
	}

	public void cambiaPausa(){
		pausaActivado = !pausaActivado;
		pausa.SetActive (pausaActivado);

		if (control.dt == 0)
			control.dt = 1;
		else
			control.dt = 0;
		
		if (Time.timeScale == 1)
			Time.timeScale = 0;
		else
			Time.timeScale = 1;
		
	}

	public void salir(){
		cambiaPausa ();
		SceneManager.LoadScene ("EntradaCastillo", LoadSceneMode.Single);
		control.defaultValues ();
	}

	public void continuar(){
		cambiaPausa ();
	}
}