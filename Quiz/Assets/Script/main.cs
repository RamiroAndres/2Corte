using UnityEngine;
using System.Collections;
using System;

public class main : MonoBehaviour {
	public Rect vTarea= new Rect(15,15,200,500);
	public Rect vActividad= new Rect(250,15,200,200);
	public Rect vTareas= new Rect(500,15,200,500);
	public Rect vActividades= new Rect(700,15,200,200);

	ventanaA a= new ventanaA();
	ventanaAs aS= new ventanaAs();
	ventanaT t= new ventanaT();
	ventanaTs tS= new ventanaTs();

	void OnGUI(){

		GUI.Box (new Rect (0, 0, 720, 500), "Quiz");
		vTarea = GUI.Window (0, vTarea, t.Create, "Tarea");
		vTareas = GUI.Window (1, vTareas, tS.Create, "Tareas");
		vActividad = GUI.Window (2, vActividad, a.Create, "Actividad");
		vActividades = GUI.Window (3, vActividades, aS.Create, "Actividades");

	}

}
