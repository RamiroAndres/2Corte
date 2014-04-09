using UnityEngine;
using System.Collections;

public class ventanaAs : MonoBehaviour {

	public void Create(int idVentana){

	}
	public void Llenar(string tSend){
		Debug.Log ("Mensaje recibido " + tSend);
		GUI.Label (new Rect (15, 15, 50, 50), tSend);
	}
}
