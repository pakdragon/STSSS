using UnityEngine;
using System.Collections;

public class PositionJoysticks : MonoBehaviour {
	
	public GUITexture movementJS;
	public GUITexture cameraJS;
	public int screenWidth;
	public int screenHeight;
	public float size;
	public float x;
	public float y;
	
	// Use this for initialization
	void Start () {
		screenWidth = Screen.width;
		screenHeight = Screen.height;
		size = screenWidth/5;
		x = screenWidth-screenWidth*(1f/10f)-size;
		y = screenWidth*(1f/10f);
		cameraJS.pixelInset = new Rect(x,y,size,size);
		//movementJS.pixelInset = new Rect(y,y,size,size);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
