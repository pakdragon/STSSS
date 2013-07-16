/* Save the Soldier Surgical Simulation
 * 
 * Year/Summer at the Edge 2012-2013
 * 
 * Dr. Rob Williams
 * 
 * Tyler Maschino
 * 
 *-----------------------------------------*/
//Note: This is still a work in progress. This script
//		is intended to get a quiz feature working in the
//		application. We got a bit of a start here.

using UnityEngine;
using System.Collections;

public class QuizScript : MonoBehaviour {
	
	public bool[] choices = new bool[4];
	public GUIStyle style = new GUIStyle();
	// Use this for initialization
	void Start () {
		reset();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {
		if (GUI.Toggle(new Rect(32,128,192,32), choices[0], "Menu")) {
        	Debug.Log("Click 1");
			reset();
			choices[0] = true;
			
		}
		if (GUI.Toggle(new Rect(32,160,192,32), choices[1], "Menu")) {
        	Debug.Log("Click 2");
			reset();
			choices[1] = true;
		}	
		if (GUI.Toggle(new Rect(32,192,192,32), choices[2], "Menu")) {
        	Debug.Log("Click 3");
			reset();
			choices[2] = true;
		}	
		if (GUI.Toggle(new Rect(32,224,192,32), choices[3], "Menu")) {
        	Debug.Log("Click 4");
			reset();
			choices[3] = true;
		}	
	}
	
	void reset() {
	 	choices[0] = false;
		choices[1] = false;
		choices[2] = false;
		choices[3] = false;
	}
}
