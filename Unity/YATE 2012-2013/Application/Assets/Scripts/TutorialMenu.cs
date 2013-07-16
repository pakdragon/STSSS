using UnityEngine;
using System.Collections;

public class TutorialMenu : MonoBehaviour {
	//public Texture2D loading;
	public GUITexture background;
	public GUITexture medial;
	public GUITexture lateral;
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		screenResize();
	
	}
	
	void OnGUI() {
		if (lateral.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)){
			//LevelLoadFade.FadeAndLoadLevel(8,loading,.5f);
			Application.LoadLevel(9);
		}
		
		if (medial.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)){
			//LevelLoadFade.FadeAndLoadLevel(9,loading,.5f);
			Application.LoadLevel(10);
		}
		
	if (GUI.Button(new Rect((5f/512f)*Screen.width,(5f/512f)*Screen.width,2*((2f/12f)*Screen.height-1f*(7f/512f)*Screen.width),(2f/12f)*Screen.height-1f*(5f/512f)*Screen.width), "Home")) {
			
			Application.LoadLevel(1);
		}
		
		
		
		
	}
	void screenResize(){
		
		background.pixelInset = new Rect(0,0,Screen.width,Screen.height);
		lateral.pixelInset = new Rect((35f/512f)*Screen.width, (95f/512f)*Screen.width, (30f/100f)*Screen.width, (20f/100f)*Screen.height);
		medial.pixelInset = new Rect((320f/512f)*Screen.width, (95f/512f)*Screen.width, (30f/100f)*Screen.width, (20f/100f)*Screen.height);
	}
		
	
	
}
