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

public class closePicture : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void Update () {
		
		//Loop through each of the pictures
		for(int i=0; i<24; i++) {
			
			//Check to see if the individual picture wants to be resized
			if (Camera.mainCamera.GetComponent<photoAlbum>().resizePic[i]) {
				
				//If so, check for clicks on the image
				if(Camera.mainCamera.GetComponent<photoAlbum>().photos[i].HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)) {
					
					//Play the click sound
					audio.Play();
					
					//Turn off the caption for the image
					Camera.mainCamera.GetComponent<photoAlbum>().captions[i].SetActive(false);
					
					//Set the picture to not want to be resized
					Camera.mainCamera.GetComponent<photoAlbum>().resizePic[i] = false;
					
					//Turn back on the photoAlbum script
					Camera.mainCamera.GetComponent<photoAlbum>().enabled = true;
				}
			}
			
			//Resize the image using the photoAlbum resize(...) method
			Camera.mainCamera.GetComponent<photoAlbum>().resize(Camera.mainCamera.GetComponent<photoAlbum>().photos[i],
						Camera.mainCamera.GetComponent<photoAlbum>().resizePic[i],
						Camera.mainCamera.GetComponent<photoAlbum>().xPic[i],
						Camera.mainCamera.GetComponent<photoAlbum>().yPic[i],
						Camera.mainCamera.GetComponent<photoAlbum>().captions[i]);
				
		}
		
	}
}