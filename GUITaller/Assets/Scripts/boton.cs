using UnityEngine;
using System.Collections;

public class boton : MonoBehaviour {
	public Texture2D TexturaBoton;
	void OnGUI(){
		//Textura
		if (GUI.Button (new Rect(100, 100, TexturaBoton.width, TexturaBoton.height), TexturaBoton)) {
		}
		//Boton
		if (GUI.Button (new Rect(100, 100, 100, 50), "Boton")) {
		}
	}
}
