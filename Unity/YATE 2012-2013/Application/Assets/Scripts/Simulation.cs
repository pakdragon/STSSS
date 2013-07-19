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

public class Simulation : MonoBehaviour {
	
	public GUITexture simulation;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//Resize the simulation graphic
		Resize ();
	}
	
	void OnGUI () {
		
		//Display button to take user back to the menu
		if (GUI.Button(new Rect((5f/512f)*Screen.width,(5f/512f)*Screen.width,2*((1f/12f)*Screen.height-2f*(5f/512f)*Screen.width),(1f/12f)*Screen.height-2f*(5f/512f)*Screen.width),"Menu")) {
			Application.LoadLevel(1);	
		}
	}
	
	void Resize () {
		
		//Resize the simulation graphic
		simulation.pixelInset = new Rect(0,0,(4f/10f)*Screen.width,(2f/10f)*Screen.width);
	}
}
