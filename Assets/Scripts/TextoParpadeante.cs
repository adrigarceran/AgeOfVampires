using UnityEngine;
using System.Collections;

//agregamos nuevos using para poder usar el New GUI
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TextoParpadeante : MonoBehaviour {

	[SerializeField]
	GameObject texto1,texto2,canvas1;
	//Agregamos las variables de Texto y Strings
	Text textoParpadeante;
	string textoQueParpadea = "Pulsa Cualquier Tecla Para Continuar";
	string textoEnBlanco = "";
	//string textoEstatico = "NO PARPADEA";

	//Agregamos una bandera que sera nuestro identificador para cambiar el texto
	bool estaParpadeando = true;

	void Start () 
	{
		//obtenemos el componente del texto
		textoParpadeante = GetComponent<Text>();

		//llamamos al coroutine de la funcion de TextoParpadeo
		StartCoroutine(TextoParpadeo());

		//llamamos a la otra funcion para saber si se detuvo el tiempo de parpadeo
		//StartCoroutine(DetenerParpadeo());
	}

	//funcion para que parpadee el texto
	public IEnumerator TextoParpadeo()
	{
		while (estaParpadeando) {

			//Establecemos nuestro texto en blanco
			textoParpadeante.text = textoEnBlanco;

			//mostramos el texto en blanco por 0.5 segundos
			yield return new WaitForSeconds (.5f);

			//mostramos nuestro texto en mi caso Depredador1220 por otros 0.5 segundos
			textoParpadeante.text = textoQueParpadea;
			yield return new WaitForSeconds (.5f);
		
		}
	}
	void Update(){
		if (Input.anyKeyDown){
			texto1.SetActive(false);
			texto2.SetActive(false);
			canvas1.SetActive(true);
		}
	}

	//funcion para detener el parpadeo
	//public IEnumerator DetenerParpadeo()
	//{
		//Esperamos por 5 segundos
	//	yield return new WaitForSeconds(5f);

		//detenemos el parpadeo
	//	estaParpadeando = false;

		//mostramos diferentes textos para probar
	//	textoParpadeante.text = textoEstatico;
	//}
} 