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

public class moviePlayer : MonoBehaviour {
	
	public GUITexture video1;
	public Texture click1;
	public Texture unclick1;
	public GUITexture video2;
	public Texture click2;
	public Texture unclick2;
	public GUITexture video3;
	public Texture click3;
	public Texture unclick3;
	public GUITexture video4;
	public Texture click4;
	public Texture unclick4;
	public GUITexture titleBar;
	public GUITexture movieBar;
	public GUITexture bar1;
	public GUITexture bar2;
	public GUITexture cap1;
	public GUITexture cap2;
	public GUITexture cap3;
	public GUITexture cap4;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		
		//Resize the GUI
		resizeGUI();
		
		//Check to see if the image for the video is clicked
		if (video1.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)) {
			
			//If so, play the click sound and change the texture to
			//make the image/button look depressed
			audio.Play();
			video1.guiTexture.texture = click1;
		}
		
		//Check to see if the image for the video is clicked
		if (video2.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)) {
			
			//If so, play the click sound and change the texture to
			//make the image/button look depressed
			audio.Play();
			video2.guiTexture.texture = click2;
		}
		
		//Check to see if the image for the video is clicked
		if (video3.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)) {
			
			//If so, play the click sound and change the texture to
			//make the image/button look depressed
			audio.Play();
			video3.guiTexture.texture = click3;
		}
		
		//Check to see if the image for the video is clicked
		if (video4.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)) {
			
			//If so, play the click sound and change the texture to
			//make the image/button look depressed
			audio.Play();
			video4.guiTexture.texture = click4;
		}
		
		//Check to see if the mouse button is released
		//and the touch/click was released within the image
		if (Input.GetMouseButtonUp(0) && video1.HitTest(Input.mousePosition)) {
			
			//Change the texture back to normal
			video1.guiTexture.texture = unclick1;
			
			//If the texture is back to normal, play the video
			if (video1.guiTexture.texture == unclick1) {
				Handheld.PlayFullScreenMovie("SATE2012 - 257 Save the Soldier Surgical Simulation (STS3) (Final).mov",Color.black, FullScreenMovieControlMode.Full, FullScreenMovieScalingMode.Fill);
			}
		}
		
		//Check to see if the mouse button is released
		//and the touch/click was released within the image
		if (Input.GetMouseButtonUp(0) && video2.HitTest(Input.mousePosition)) {
			
			//Change the texture back to normal
			video2.guiTexture.texture = unclick2;
			
			//If the texture is back to normal, play the video
			if (video2.guiTexture.texture == unclick2) {
				Handheld.PlayFullScreenMovie("Dr. McCarthy.mov",Color.black, FullScreenMovieControlMode.Full, FullScreenMovieScalingMode.Fill);
			}
		}
		
		//Check to see if the mouse button is released
		//and the touch/click was released within the image
		if (Input.GetMouseButtonUp(0) && video3.HitTest(Input.mousePosition)) {
			
			//Change the texture back to normal
			video3.guiTexture.texture = unclick3;
			
			//If the texture is back to normal, play the video
			if (video3.guiTexture.texture == unclick3) {
				Handheld.PlayFullScreenMovie("SATE2012 STS3 - Fasciotomy, Cadaver Dissection - Medial Incision.mov",Color.black, FullScreenMovieControlMode.Full, FullScreenMovieScalingMode.Fill);
			}
		}
		
		//Check to see if the mouse button is released
		//and the touch/click was released within the image
		if (Input.GetMouseButtonUp(0) && video4.HitTest(Input.mousePosition)) {
			
			//Change the texture back to normal
			video4.guiTexture.texture = unclick4;
			
			//If the texture is back to normal, play the video
			if (video4.guiTexture.texture == unclick4) {
				Handheld.PlayFullScreenMovie("SATE2012 STS3 - Fasciotomy, Cadaver Dissection - Lateral Incision.mov",Color.black, FullScreenMovieControlMode.Full, FullScreenMovieScalingMode.Fill);
			}
		}
		
		//No matter where the click/touch is released, reset the texture
		if (Input.GetMouseButtonUp(0)) {
			video1.guiTexture.texture = unclick1;
			video2.guiTexture.texture = unclick2;
			video3.guiTexture.texture = unclick3;
			video4.guiTexture.texture = unclick4;
		}
		
	}
	
	//Resize the screen to fit the device
	public void resizeGUI() {
		
		//Resize banners
		titleBar.pixelInset = new Rect(0,0,Screen.width, (1f/12f)*Screen.height);
		movieBar.pixelInset = new Rect(0,Screen.height-(1f/12f)*Screen.height,Screen.width, (1f/12f)*Screen.height);
		bar1.pixelInset = new Rect(0,(1f/12f)*Screen.height,Screen.width,(1f/192f)*Screen.height);
		bar2.pixelInset = new Rect(0,Screen.height-(1f/12f)*Screen.height-(1f/192f)*Screen.height,Screen.width,(1f/192f)*Screen.height);
		
		//Resize thumbnails
		video1.pixelInset = new Rect((1f/32f)*Screen.width,(1f/8f)*Screen.height,(29f/64f)*Screen.width,(17f/48f)*Screen.height);
		video2.pixelInset = new Rect((33f/64f)*Screen.width,(1f/8f)*Screen.height,(29f/64f)*Screen.width,(17f/48f)*Screen.height);
		video3.pixelInset = new Rect((1f/32f)*Screen.width,(25f/48f)*Screen.height,(29f/64f)*Screen.width,(17f/48f)*Screen.height);
		video4.pixelInset = new Rect((33f/64f)*Screen.width,(25f/48f)*Screen.height,(29f/64f)*Screen.width,(17f/48f)*Screen.height);
		
		//Resize captions
		cap1.pixelInset = new Rect((1f/16f)*Screen.width,(47f/96f)*Screen.height,(25f/64f)*Screen.width,(1f/48f)*Screen.height);
		cap2.pixelInset = new Rect((35f/64f)*Screen.width,(47f/96f)*Screen.height,(25f/64f)*Screen.width,(1f/48f)*Screen.height);
		cap3.pixelInset = new Rect((1f/16f)*Screen.width,(3f/32f)*Screen.height,(25f/64f)*Screen.width,(1f/48f)*Screen.height);
		cap4.pixelInset = new Rect((35f/64f)*Screen.width,(3f/32f)*Screen.height,(25f/64f)*Screen.width,(1f/48f)*Screen.height);
	}
	
	void OnGUI () {
		
		//Display button to take user back to menu
		if (GUI.Button(new Rect((5f/512f)*Screen.width,(5f/512f)*Screen.width,2*((1f/12f)*Screen.height-2f*(5f/512f)*Screen.width),(1f/12f)*Screen.height-2f*(5f/512f)*Screen.width),"Menu")) {
			Application.LoadLevel(1);	
		}
	}
	
}
