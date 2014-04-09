using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {
	
	public float ScrollH;
	public float ScrollV;
	// Update is called once per frame
	void OnGUI() {
		ScrollH = GUI.HorizontalScrollbar (new Rect (150, 200, 80, 50), ScrollH, 1.0f, 1.0f, 1000.0f);
		ScrollV = GUI.VerticalScrollbar (new Rect (50, 50, 200, 70), ScrollV, 1.0f, 2000.0f, 10.0f);
	}
}
