using UnityEngine;
using System.Collections;

public class PlatformGui : MonoBehaviour {
	
	
	public GameObject player;
	public GameObject dish;
	public GUITexture help;
	

	// Use this for initialization
	void Start () {
		
		helpResize();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//dish.transform.position = new Vector3 (-33.4f, 6.066f, -6.55f);
	
		
		if (player.transform.position.x <= -32f && player.transform.position.x >= -34f &&  player.transform.position.y >= 6f && player.transform.position.z >= -7.5f && player.transform.position.z <= -5.4f){
			
			help.enabled = true;
		}
		
		else{
			help.enabled = false;
		}
		
		
	}
	
	
	
	void helpResize(){
		
		help.pixelInset = new Rect((2f/5f)*Screen.width,(1f/5f)*Screen.height, (5f/6f)*Screen.width,(5f/6f)*Screen.height);
	}
}
