using UnityEngine;
using System.Collections;
using System;

public class General : MonoBehaviour{
    public Rect vTarea = new Rect(30, 30, 150, 100);
    public Rect vActividad = new Rect(30, 150, 150, 100);
    public Rect vTareas = new Rect(200, 30, 200, 220);
    public Rect vActividades = new Rect(450, 30, 200, 220);
    public string textoTarea = "";
    public string tSendTarea = "";
	public string textoActividad = "";
	public string tSendActividad = "";

    void OnGUI(){
        GUI.Box(new Rect(0, 0, 700, 300), "Quiz");
        vTarea = GUI.Window(0, vTarea, CreateT, "Tarea");
        vTareas = GUI.Window(1, vTareas, CreateTs, "Tareas");
       	vActividad = GUI.Window(2, vActividad, CreateA, "Actividad");
        vActividades = GUI.Window(3, vActividades, CreateAs, "Actividades");
    }
    //Creecion Ventana Tarea
    public void CreateT(int idVentana){
        textoTarea = GUI.TextField(new Rect(25, 30, 100, 20), textoTarea, 50);
        if (GUI.Button(new Rect(25, 50, 100, 30), "Crear")){
			tSendTarea = tSendTarea+textoTarea+"\n";
			textoTarea="";
        }
    }
	//Creacion Ventana Actividad
	public void CreateA(int idVentana){
		ventanaAs vAs = new ventanaAs();
		textoActividad= GUI.TextField(new Rect(25, 30, 100, 20), textoActividad, 50);
		if (GUI.Button(new Rect(25, 50, 100, 30), "Crear")){
			tSendActividad = textoActividad+"\n"+tSendActividad;
			textoActividad="";
		}
	}
	/*-----------------------------------------------*/

    //Creacion y llenar tareas
    public void CreateTs(int idVentana){
		GUI.Label(new Rect (80, 30, 100, 150), tSendTarea);
	}
	//Creacion y llenar Actividades
	public void CreateAs(int idVentana){
		GUI.Label(new Rect(80, 30, 100, 150), tSendActividad);
	}

}
