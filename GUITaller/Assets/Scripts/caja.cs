using UnityEngine;
using System.Collections;

public class caja : MonoBehaviour {
	public Texture2D Fondo;
	// Use this for initialization
	void OnGUI(){
		//GUI.Box (new Rect (0, 0, Fondo.width, Fondo.height), Fondo,"Box ejemplo");
		GUI.Box (new Rect (1200, 800, Screen.width,Screen.height ), "Bok Ejemplo");
		}
}
