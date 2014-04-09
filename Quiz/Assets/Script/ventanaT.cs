using UnityEngine;
using System.Collections;

public class ventanaT : MonoBehaviour {
	public string texto="";
	public string tSend="";
	public void Create(int idVentana){
		ventanaTs vTs = new ventanaTs ();
		texto=GUI.TextField(new Rect(50,75,100,20),texto,50);
		if (GUI.Button (new Rect(50, 100, 100, 30), "Crear")) {
			tSend=texto;
			vTs.enviar(tSend);
		}
		GUI.Label (new Rect (100, 15, 50, 50), tSend);
	}
}
