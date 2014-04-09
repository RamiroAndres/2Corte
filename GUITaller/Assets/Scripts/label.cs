using UnityEngine;
using System.Collections;

public class label : MonoBehaviour {

	// Use this for initialization
	void OnGUI() {
		GUI.Label (new Rect (50, 50, 300, 150), "Ejemplo Label");
	}
}
