using UnityEngine;
using System.Collections;

public class ventanaTs : MonoBehaviour {

	public void Create(int idVentana){

	}
	public void enviar(string tSend){
		Debug.Log ("Mensaje recibido " + tSend);
		GUI.Label (new Rect (100, 15, 50, 50), tSend);
		if (GUI.Button (new Rect(100, 100, 100, 50), "Boton")) {
		}
		llenar(tSend);
	}
	public void llenar(string tSend){
		GUI.Label (new Rect (100, 15, 50, 50), tSend);
		if (GUI.Button (new Rect(100, 100, 100, 50), "Boton")) {
		}
	}
}
