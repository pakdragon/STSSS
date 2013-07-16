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

public class photoAlbum : MonoBehaviour {
	
	//There are 24 images in total on the screen
	public GUITexture[] photos = new GUITexture[24];
	public GameObject album;
	public bool[] resizePic;
	public float[] widthPic;
	public float[] heightPic;
	public float[] xPic;
	public float[] yPic;
	public GameObject[] captions = new GameObject[24];
	private float changeX;
	private float changeY;
	private float changeWidth;
	private float changeHeight;
	public float width;
	public float height;
	public float x;
	public float y;
	public float a;
	public GUITexture background;
	public GUITexture bar1;
	public GUITexture bar2;
	public GUITexture titleBar;
	public GUITexture photosBar;
	
	// Use this for initialization
	void Start () {
		
		//Resize the screen with respect to size of the screen on the device
		screenResize();
		
		//Array for holding info on whether an image is resized or not
		//Resized in this case means either it is enlarged or it is just a thumbnail
		resizePic = new bool[24];
		
		//x position for each image
		xPic = new float[24];
		
		//y position for each image
		yPic = new float[24];
		
		//width of each picture
		widthPic = new float[24];
		
		//height of each picture
		heightPic = new float[24];
		
		//set the background color to be white and completely transparent
		background.guiTexture.color = new Color(255,255,255, 0f);
		
		//transparency
		//0 means transparent, 1 means opaque
		a = 0f;
		
		//set background position
		background.transform.localPosition = new Vector3(0,0,4);
		
		//populate arrays with values from each of the game objects
		for (int i=0; i<24; i++) {
			resizePic[i] = false;
			xPic[i] = photos[i].pixelInset.x;
			yPic[i] = photos[i].pixelInset.y;
			widthPic[i] = photos[i].pixelInset.width;
			heightPic[i] = photos[i].pixelInset.height;
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//Go through each thumbnail
		for (int i=0; i<24; i++) {
			
			//Check for clicks on each image
			if (photos[i].HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)) {
				
				//If the image is clicked, play the click noise
				audio.Play();
				
				//Change the value of resize
				resizePic[i] = !resizePic[i];
			}
			
			//If resize is true, move the picture to the front of all other images
			if (resizePic[i]) {
				photos[i].transform.localPosition = new Vector3(0,0,5);
			}
			
			//Resize the image
			resize(photos[i],resizePic[i],xPic[i],yPic[i],captions[i]);
		
		}
	}
	
	public void resize(GUITexture picture,bool resizePic, float originalX, float originalY, GameObject caption) {
		
		//Store the information from the picture in variables
		y = picture.pixelInset.y;
		x = picture.pixelInset.x;
		width = picture.pixelInset.width;
		height = picture.pixelInset.height;
		
		//Calculate the incremental change in position for the image
		changeX = (float) (Screen.width/4f-originalX)/16;
		changeY = (float) (Screen.height/4f-originalY)/16;
		
		//Check to see if the image is requesting to be resized (get bigger)
		if (resizePic) {
			
			//If resize is true and the current image width/height is less than those specified
			//increment the width, height, position, and transparency of background
			if (width<(Screen.width/2f) || height<(Screen.height/2f)) {
				width+=(.046875f*(Screen.width/2f));
				height+=(.046875f*(Screen.height/2f));
				x+=changeX;
				y+=changeY;
				a+=.03125f;
				picture.pixelInset = new Rect(x,y,width,height);
				background.guiTexture.color = new Color(255,255,255,a);
				
			}
			
			//Resize is true and the current image is at the correct size (the big size)
			else {
				
				//Turn on the caption for the image
				caption.SetActive(true);
				
				//Enable the script that allows the picture to be closed
				Camera.mainCamera.GetComponent<closePicture>().enabled = true;
				
				//Disable the script that allows the image to resize (get bigger)
				Camera.mainCamera.GetComponent<photoAlbum>().enabled = false;
			}
		}
		
		//If the image is not requesting to be resized, the image will get smaller
		else {
			
			//If the image is larger than the specifications below, then it will be incrementally
			//resized, repositioned, and the background will become transparent
			if (width>((1f/8f)*Screen.width) || height>((1f/8f)*Screen.width)) {
				width-=(.046875f*(Screen.width/2f));
				height-=(.046875f*(Screen.height/2f));	
				x-=changeX;
				y-=changeY;
				a-=.03125f;
				picture.pixelInset = new Rect(x,y,width,height);
				background.guiTexture.color = new Color(255,255,255,a);
				
			}
			
			//If the image equals the requested size, the caption will be turned off and
			//the image's z-value will be set back to 0, positioning the image back to its
			//original layer level
			if (width==((1f/8f)*Screen.width) || height==((1f/8f)*Screen.width)) {
				caption.SetActive(false);
				picture.transform.localPosition = new Vector3(0,0,0);
				
			}
		}
	}
	
	//Resize the GUI to fit the device
	void screenResize() {
		
		//Resize banners
		titleBar.pixelInset = new Rect(0,0,Screen.width, (1f/12f)*Screen.height);
		photosBar.pixelInset = new Rect(0,Screen.height-(1f/12f)*Screen.height,Screen.width, (1f/12f)*Screen.height);
		bar1.pixelInset = new Rect(0,(1f/12f)*Screen.height,Screen.width,(1f/192f)*Screen.height);
		bar2.pixelInset = new Rect(0,Screen.height-(1f/12f)*Screen.height-(1f/192f)*Screen.height,Screen.width,(1f/192f)*Screen.height);
		
		//Resize gradient (background used for transparency/opacity)
		background.pixelInset = new Rect(0,(17f/192f)*Screen.height,Screen.width,(158f/192f)*Screen.height);
		
		//Resize captions
		for (int i=0; i<24; i++) {
			captions[i].guiTexture.pixelInset = new Rect((9f/32f)*Screen.width,(3f/16f)*Screen.height,(7f/16f)*Screen.width,(1f/24f)*Screen.height);
		}
		
		//Resize all photos
		for (int i=0; i<24; i++) {
			photos[i].pixelInset = new Rect(photos[i].pixelInset.x, photos[i].pixelInset.y, (12.5f/100f)*Screen.width, (12.5f/100f)*Screen.height);
		}
		
		//Reposition first column
		for (int i=0; i<19; i=i+6) { //These weird integers below are the percent of the screen width that is "tabbed" right before placing the picture.
			photos[i].pixelInset = new Rect(.046875f*Screen.width, photos[i].pixelInset.y, photos[i].pixelInset.width, photos[i].pixelInset.height);
		}
		//Reposition second column
		for (int i=1; i<20; i=i+6) {
			photos[i].pixelInset = new Rect(.203125f*Screen.width, photos[i].pixelInset.y, photos[i].pixelInset.width, photos[i].pixelInset.height);
		}
		//Reposition third column
		for (int i=2; i<21; i=i+6) {
			photos[i].pixelInset = new Rect(.359375f*Screen.width, photos[i].pixelInset.y, photos[i].pixelInset.width, photos[i].pixelInset.height);
		}
		//Reposition fourth column
		for (int i=3; i<22; i=i+6) {
			photos[i].pixelInset = new Rect(.515625f*Screen.width, photos[i].pixelInset.y, photos[i].pixelInset.width, photos[i].pixelInset.height);
		}
		//Reposition fifth column
		for (int i=4; i<23; i=i+6) {
			photos[i].pixelInset = new Rect(.671875f*Screen.width, photos[i].pixelInset.y, photos[i].pixelInset.width, photos[i].pixelInset.height);
		}
		//Reposition sixth column
		for (int i=5; i<24; i=i+6) {
			photos[i].pixelInset = new Rect(.828125f*Screen.width, photos[i].pixelInset.y, photos[i].pixelInset.width, photos[i].pixelInset.height);
		}
		
		//Reposition first row
		for (int i=0; i<6; i++) { //These weird integers below are the percent of the screen height that is "tabbed" up before placing the picture.
			photos[i].pixelInset = new Rect(photos[i].pixelInset.x, .125f*Screen.height, photos[i].pixelInset.width, photos[i].pixelInset.height);
		}
		//Reposition second row
		for (int i=6; i<12; i++) {
			photos[i].pixelInset = new Rect(photos[i].pixelInset.x, (1f/3f)*Screen.height, photos[i].pixelInset.width, photos[i].pixelInset.height);
		}
		//Reposition third row
		for (int i=12; i<18; i++) {
			photos[i].pixelInset = new Rect(photos[i].pixelInset.x, (13f/24f)*Screen.height, photos[i].pixelInset.width, photos[i].pixelInset.height);
		}
		//Reposition fourth row
		for (int i=18; i<24; i++) {
			photos[i].pixelInset = new Rect(photos[i].pixelInset.x, .75f*Screen.height, photos[i].pixelInset.width, photos[i].pixelInset.height);
		}
	}
	
	void OnGUI () {
		
		//Display menu button to take user back to menu screen
		if (GUI.Button(new Rect((5f/512f)*Screen.width,(5f/512f)*Screen.width,2*((1f/12f)*Screen.height-2f*(5f/512f)*Screen.width),(1f/12f)*Screen.height-2f*(5f/512f)*Screen.width),"Menu")) {
			Application.LoadLevel(1);	
		}
	}
}
