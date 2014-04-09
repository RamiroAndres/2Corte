using UnityEngine;
using System.Collections;
using System;

public class color : MonoBehaviour {
	GameObject cube = new GameObject ();
	GameObject sphere = new GameObject ();
	GameObject plane = new GameObject ();
	GameObject capsule = new GameObject ();
	public Rect ventana= new Rect(15,15,200,500);
	public Rect ventanac= new Rect(250,15,200,200);
	public Rect ventanacp= new Rect(500,15,200,500);
	public Rect ventanas= new Rect(700,15,200,200);
	public Rect ventanap= new Rect(900,15,200,200);
	public float sliderValc = 0.0f;
	public float sliderVals = 0.0f;
	public float sliderValcp = 0.0f;
	public float sliderValp = 0.0f;
	float rc,gc,bc;
	float rs,gs,bs;
	float rcp,gcp,bcp;
	float rp,gp,bp;
	int banc,bancp,bans,banp;
	public int var=0;

	void OnGUI(){
		ventana = GUI.Window (0, ventana, Create, "Objects");
		ventanac = GUI.Window (1, ventanac, CreateCube, "Color Cube");
		ventanas = GUI.Window (2, ventanas, CreateSphere, "Color Sphere");
		ventanacp = GUI.Window (3, ventanacp, CreateCapsule, "Color Capsule");
		ventanap = GUI.Window (4, ventanap, CreatePlane, "Color Plane");
	}
	void Create(int idVentana){
		//Botones y creacion de Objetos
		if (GUI.Button (new Rect (50, 50, 100, 50), "Cubo")) {
			if (banc == 0)
				cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
			else
				Debug.Log("Cube already existing");
			cube.name = "Cube";
			cube.transform.position = new Vector3 (-5, 0, 10);
			cube.transform.localScale = new Vector3 (1, 1, 1);
			banc=1;
		}
		if (GUI.Button (new Rect (50, 100, 100, 50), "Sphere")) {
			if (bans == 0)
				sphere = GameObject.CreatePrimitive (PrimitiveType.Sphere);
			else
				Debug.Log("Sphere already existing");
			sphere.name = "Sphere";
			sphere.transform.position = new Vector3 (0, 0, 10);
			sphere.transform.localScale = new Vector3 (1, 1, 1);
			bans=1;
		}
		if (GUI.Button (new Rect (50, 150, 100, 50), "Capsule")) {
			if (bancp == 0)
				capsule = GameObject.CreatePrimitive (PrimitiveType.Capsule);
			else
				Debug.Log("Capsule already existing");
			capsule.name = "Capsule";
			capsule.transform.position = new Vector3 (5, 0, 10);
			capsule.transform.localScale = new Vector3 (1, 1, 1);
			bancp=1;
		}
		if (GUI.Button (new Rect (50, 200, 100, 50), "Plane")) {
			if (banp == 0)	
				plane = GameObject.CreatePrimitive (PrimitiveType.Plane);
			else
				Debug.Log("Plane already existing");
			plane.name = "Plane";
			plane.transform.position = new Vector3 (0, -3, 10);
			plane.transform.localScale = new Vector3 (1, 1, 1);
			banp=1;
		}

		//Label
		GUI.Label (new Rect (65, 250, 100, 20), "GlobalColor");
		//ColoresGlobales
		if (GUI.Button (new Rect (60, 270, 80, 30), "Red")) {	
			cube.renderer.material.color = Color.red;
			sphere.renderer.material.color = Color.red;
			capsule.renderer.material.color = Color.red;
			plane.renderer.material.color = Color.red;
		}
		if (GUI.Button (new Rect (60, 300, 80, 30), "Green")) {	
			cube.renderer.material.color = Color.green;
			sphere.renderer.material.color = Color.green;
			capsule.renderer.material.color = Color.green;
			plane.renderer.material.color = Color.green;
		}
		if (GUI.Button (new Rect (60, 330, 80, 30), "Blue")) {	
			cube.renderer.material.color = Color.blue;
			sphere.renderer.material.color = Color.blue;
			capsule.renderer.material.color = Color.blue;
			plane.renderer.material.color = Color.blue;
		}
		if (GUI.Button (new Rect (60, 360, 80, 30), "Yellow")) {	
			cube.renderer.material.color = Color.yellow;
			sphere.renderer.material.color = Color.yellow;
			capsule.renderer.material.color = Color.yellow;
			plane.renderer.material.color = Color.yellow;
		}
		if (GUI.Button (new Rect (60, 390, 80, 30), "Gray")) {	
			cube.renderer.material.color = Color.gray;
			sphere.renderer.material.color = Color.gray;
			capsule.renderer.material.color = Color.gray;
			plane.renderer.material.color = Color.gray;
		}
		if (GUI.Button (new Rect (60, 420, 80, 30), "Black")) {	
			cube.renderer.material.color = Color.black;
			sphere.renderer.material.color = Color.black;
			capsule.renderer.material.color = Color.black;
			plane.renderer.material.color = Color.black;
		}
	}
	//ColorIndividual
	void CreateCube(int idVentana){
		GUI.Label (new Rect (20, 15, 100, 20), "Cube");
		rc = GUI.HorizontalSlider (new Rect (10,45,250,10),rc, 0.0f, 1.0f);
		gc = GUI.HorizontalSlider (new Rect (10,60,250,10),gc, 0.0f, 1.0f);
		bc = GUI.HorizontalSlider (new Rect (10,75,250,10),bc, 0.0f, 1.0f);
        cube.renderer.material.color = new Color(rc, gc, bc);
	}
	void CreateSphere(int idVentana){
		GUI.Label (new Rect (20, 15, 100, 20), "Sphere");		
		rs = GUI.HorizontalSlider (new Rect (10,45,250,10),rs, 0.0f, 1.0f);
		gs = GUI.HorizontalSlider (new Rect (10,60,250,10),gs, 0.0f, 1.0f);
		bs = GUI.HorizontalSlider (new Rect (10,75,250,10),bs, 0.0f, 1.0f);
		sphere.renderer.material.color = new Color (rs, gs, bs);
	}
	void CreateCapsule(int idVentana){
		GUI.Label (new Rect (20, 15, 100, 20), "Capsule");		
		rcp = GUI.HorizontalSlider (new Rect (10,45,250,10),rcp, 0.0f, 1.0f);
		gcp = GUI.HorizontalSlider (new Rect (10,60,250,10),gcp, 0.0f, 1.0f);
		bcp = GUI.HorizontalSlider (new Rect (10,75,250,10),bcp, 0.0f, 1.0f);
	    capsule.renderer.material.color = new Color (rcp, gcp, bcp);
	}
	void CreatePlane(int idVentana){
		GUI.Label (new Rect (20, 15, 100, 20), "Plane");		
		rp = GUI.HorizontalSlider (new Rect (10,45,250,10),rp, 0.0f, 1.0f);
		gp = GUI.HorizontalSlider (new Rect (10,60,250,10),gp, 0.0f, 1.0f);
		bp = GUI.HorizontalSlider (new Rect (10,75,250,10),bp, 0.0f, 1.0f);
		plane.renderer.material.color = new Color (rp, gp, bp);
	}
   /* void Update(){
        cube.renderer.material.color = new Color(rc, gc, bc);
        sphere.renderer.material.color = new Color(rs, gs, bs);
        capsule.renderer.material.color = new Color(rcp, gcp, bcp);
        plane.renderer.material.color = new Color(rp, gp, bp);
    }*/
}
