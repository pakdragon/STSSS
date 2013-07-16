using UnityEngine;
using System.Collections;

public class TutorialMenu : MonoBehaviour {
	public Texture2D loading;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {
		if (GUI.Button(new Rect((250f/512f)*Screen.width,(120f/512f)*Screen.width,4f*((2f/12f)*Screen.height-2f*(7f/512f)*Screen.width),(4f/12f)*Screen.height-1f*(7f/512f)*Screen.width), "Lateral")) {
			//LevelLoadFade.FadeAndLoadLevel(8,loading,.5f);
			Application.LoadLevel(9);
		}
		
		if (GUI.Button(new Rect((250f/512f)*Screen.width,(20f/512f)*Screen.width,4f*((2f/12f)*Screen.height-2f*(7f/512f)*Screen.width),(4f/12f)*Screen.height-1f*(7f/512f)*Screen.width), "Medial")) {
			//LevelLoadFade.FadeAndLoadLevel(9,loading,.5f);
			Application.LoadLevel(10);
		}
		
	if (GUI.Button(new Rect((30f/512f)*Screen.width,(100f/512f)*Screen.width,5f*((2f/12f)*Screen.height-2f*(7f/512f)*Screen.width),(4f/12f)*Screen.height-1f*(7f/512f)*Screen.width), "Home")) {
			
			Application.LoadLevel(1);
		}
		
		
		
		
	
	}
}
