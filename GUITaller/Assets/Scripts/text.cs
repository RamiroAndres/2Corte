using UnityEngine;
using System.Collections;

public class text : MonoBehaviour {
	public string textoArea = "Escriba aqui";
	public string textoField = "Escriba aqui";

	void OnGUI(){
		//TextArea
		textoArea = GUI.TextArea (new Rect (50, 50, 500, 300), textoArea, 200);
		//TextField
		textoField=GUI.TextField(new Rect(500,500,150,100),textoField,50);
	}
}

		


