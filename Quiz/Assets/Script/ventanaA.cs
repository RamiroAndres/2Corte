using UnityEngine;
using System.Collections;

public class ventanaA : MonoBehaviour {
	public string texto="";
	public string tSend="";
	public void Create(int idVentana){
		ventanaAs vAs = new ventanaAs ();
		texto=GUI.TextField(new Rect(50,75,100,20),texto,50);
		if (GUI.Button (new Rect(50, 100, 100, 30), "Crear")) {
			tSend=texto;
			vAs.Llenar(tSend);
		}
	}
}
