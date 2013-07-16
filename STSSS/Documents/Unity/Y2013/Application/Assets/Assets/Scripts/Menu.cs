/* Save the Soldier Surgical Simulation
 * 
 * Year/Summer at the Edge 2012-2013
 * 
 * Dr. Rob Williams
 * 
 * Tyler Maschino
 * 
 *-----------------------------------------*/

using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	
	//public GUITexture simulation;
	public GUITexture tutorial;
	public GUITexture background;
	public GUITexture photos;
	public GUITexture videos;
	public GUITexture sticky;
	//public GUITexture compartmentSyndrome;
	public GUITexture about;
	public Texture2D loading;
	// Use this for initialization
	void Start () {
		Screen.showCursor = true;
	}
	
	// Update is called once per frame
	void Update () {
		
		//Resize the GUI
		Resize();
		
		//background.guiTexture.color = new Color(255,255,255, 0f);
		
		
		
		background.transform.localPosition = new Vector3(0,0,2);
		
		//Check to see if the Simulation button is clicked
		//if (simulation.HitTest(Input.mousePosition) && (Input.GetMouseButtonUp(0))) {
		//	LevelLoadFade.FadeAndLoadLevel(1,loading,.5f);	
			
			//Load the Simulation
		//	Application.LoadLevel(2);
		//}
		
		//Check to see if the Tutorial button is clicked
		if (tutorial.HitTest(Input.mousePosition) && Input.GetMouseButtonUp(0)) {
			
			//Load the Tutorial
			Application.LoadLevel (3);
		}
		
		//Check to see if the Photos button is clicked
		if (photos.HitTest(Input.mousePosition) && Input.GetMouseButtonUp(0)) {
			//LevelLoadFade.FadeAndLoadLevel(3,loading,.5f);
			
			//Load the Photo album
			Application.LoadLevel(4);	
		}
		
		//Check to see if the Videos button is clicked
		if (videos.HitTest(Input.mousePosition) && Input.GetMouseButtonUp(0)) {
			//LevelLoadFade.FadeAndLoadLevel(4,loading,.5f);
			
			//Load the Video archive
			Application.LoadLevel(5);
		}
		
		//Blank – Defunct, ignore this one. This is the 6th space on the screen (blank)
		//if (compartmentSyndrome.HitTest(Input.mousePosition) && Input.GetMouseButtonUp(0)) {
			//LevelLoadFade.FadeAndLoadLevel(5,loading,.5f);
			
			//Load the blank slide – don't do this, it goes nowhere
			//Application.LoadLevel(6);
		//}
		
		//Check to see if the About button is clicked
		if (about.HitTest(Input.mousePosition) && Input.GetMouseButtonUp(0)) {
			//LevelLoadFade.FadeAndLoadLevel(7,loading,.5f);
			Application.LoadLevel(7);
		}
	}
	
	void OnGUI() {
		
		//Display menu button that takes the user back to the main menu
		if (GUI.Button(new Rect((5f/512f)*Screen.width,(5f/512f)*Screen.width,2*((1f/12f)*Screen.height-2f*(5f/512f)*Screen.width),(1f/12f)*Screen.height-2f*(5f/512f)*Screen.width),"Shut Down")) {
			
			//Load computer menu
			Application.LoadLevel(0);	
		}
	}
	
	//Resize the GUI
	void Resize() {
		
		//Resizes each GUI element
		//simulation.pixelInset = new Rect((3f/32f)*Screen.width,(14f/24f)*Screen.height,(3f/8f)*Screen.width,(1f/6f)*Screen.height);
		tutorial.pixelInset = new Rect((17f/32f)*Screen.width,(14f/24f)*Screen.height,(3f/8f)*Screen.width,(1f/6f)*Screen.height);
		photos.pixelInset = new Rect((3f/32f)*Screen.width,(8f/24f)*Screen.height,(3f/8f)*Screen.width,(1f/6f)*Screen.height);
		videos.pixelInset = new Rect((17f/32f)*Screen.width,(8f/24f)*Screen.height,(3f/8f)*Screen.width,(1f/6f)*Screen.height);
		sticky.pixelInset = new Rect((17f/32f)*Screen.width,(10f/24f)*Screen.height,(3f/8f)*Screen.width,(1f/6f)*Screen.height);
		//compartmentSyndrome.pixelInset = new Rect((3f/32f)*Screen.width,(2f/24f)*Screen.height,(3f/8f)*Screen.width,(1f/6f)*Screen.height);
		about.pixelInset = new Rect((17f/32f)*Screen.width,(2f/24f)*Screen.height,(3f/8f)*Screen.width,(1f/6f)*Screen.height);
		background.pixelInset = new Rect(0,(.1f/192f)*Screen.height,Screen.width,Screen.height);
	}
}
