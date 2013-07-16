using UnityEngine;
using System.Collections;

public class BackGuiButton : MonoBehaviour {
	
	public GameObject legcamera;
	public GUITexture backbutton;
	public GameObject player;

	// Use this for initialization
	void Start () {
	
		Screen.showCursor = true;
	}
	
	// Update is called once per frame
	void Update () {
			if (backbutton.HitTest(Input.mousePosition) && Input.GetMouseButtonUp(0)){
			
			player.transform.position = new Vector3(-4.892138f, 6.965034f, -5.814781f);
			
			//Application.LoadLevel (0);
		}
		
		
   		
	
	
	}

}