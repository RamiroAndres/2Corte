using UnityEngine;
using System.Collections;

public class ventanas : MonoBehaviour {
	public Rect ventana= new Rect(50,50,300,400);
	public Rect ventana1= new Rect(50,100,300,400);
	public string textoArea = "Escriba aqui";
	void OnGUI(){
		ventana = GUI.Window (0, ventana, Crear, "Ventana");
		ventana1 = GUI.Window (1, ventana1, Crear, "Ventana1");
	}
	void Crear(int idVentana){
		if (GUI.Button (new Rect (50, 50, 100, 50), "Presionar"))
			print ("Boton presionado");
		textoArea = GUI.TextArea (new Rect (100, 100, 100, 200), textoArea, 200);
	}

}
