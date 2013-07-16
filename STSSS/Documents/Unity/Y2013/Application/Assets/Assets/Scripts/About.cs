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

public class About : MonoBehaviour {
	
	//STS3 banner across bottom of screen
	public GUITexture titleBar;
	
	//Banner across top of screen
	public GUITexture aboutBar;
	
	//Gray bar across top and bottom of screen
	public GUITexture bar1;
	public GUITexture bar2;
	
	//Center image/text
	public GUITexture about;
	
	void Update() {
	
		//call function to resize the GUI based on screen parameters
		resizeGUI();
		
	}
	
	public void resizeGUI() {
		
		//Resize each of the banners
		titleBar.pixelInset = new Rect(0,0,Screen.width, (1f/12f)*Screen.height);
		aboutBar.pixelInset = new Rect(0,Screen.height-(1f/12f)*Screen.height,Screen.width, (1f/12f)*Screen.height);
		bar1.pixelInset = new Rect(0,(1f/12f)*Screen.height,Screen.width,(1f/192f)*Screen.height);
		bar2.pixelInset = new Rect(0,Screen.height-(1f/12f)*Screen.height-(1f/192f)*Screen.height,Screen.width,(1f/192f)*Screen.height);
		
		//Resize text/image in center of screen
		about.pixelInset = new Rect(0,(17f/192f)*Screen.height,Screen.width,(79f/96f)*Screen.height);
		
	}
	
	void OnGUI () {
		
		//Place GUI button on screen to take you back to menu
		if (GUI.Button(new Rect((5f/512f)*Screen.width,(5f/512f)*Screen.width,2*((1f/12f)*Screen.height-2f*(5f/512f)*Screen.width),(1f/12f)*Screen.height-2f*(5f/512f)*Screen.width),"Menu")) {
			Application.LoadLevel(1);	
		}
	}
}
