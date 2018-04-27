using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class control {

	public static float dt=1;
	public static bool libro=false;
	public static bool cruz=false;
	public static bool gema=false;
	public static bool efectos=true;
	public static int objetos = 3;
	public static bool enemigoActivo = false;
	public static bool enemigoVivo = true;
	public static bool personajeMuerto = false;

	public static void defaultValues(){
		libro=false;
		cruz=false;
		gema=false;
		efectos=true;
		objetos = 3;
		enemigoActivo = false;
		enemigoVivo = true;
	}
}
