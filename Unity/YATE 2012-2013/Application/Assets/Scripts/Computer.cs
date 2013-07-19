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

public class Computer : MonoBehaviour {
	
	public GameObject computer;
	public GameObject PCController;
	public GameObject computerScreen;
	public Material computerOn;
	public Material computerOff;
	public float time;
	// Use this for initialization
	void Start () {
		
		//Set time to be 0
		time = 0f;
		Debug.Log("Started");
	}
	
	// Update is called once per frame
	void Update() {
		
		//Check to see if computer and player are close (as defined below)
		if (Mathf.Abs(computer.transform.position.z-this.transform.position.z)<=1.5 && Mathf.Abs(computer.transform.position.x-this.transform.position.x)<=.5) {
			
			//Turn off the audio source
			PCController.GetComponent<AudioSource>().enabled = false;
			
			//Disable the MouseLook script
			this.GetComponent<MouseLook>().enabled = false;
			PCController.GetComponent<MouseLook>().enabled = false;
			
			//Move and rotate the character to specified position
			iTween.MoveTo(PCController,new Vector3(computer.transform.position.x,0,computer.transform.position.z-1.5f),10);
			iTween.RotateTo(PCController,iTween.Hash("rotation",new Vector3(0,0,0),"time",10));
			iTween.RotateTo(this.gameObject,iTween.Hash("rotation",new Vector3(0,0,0),"time",10));
			iTween.MoveTo(this.gameObject,new Vector3(computer.transform.position.x,computer.transform.position.y+.35f,computer.transform.position.z-.5f),10);
			
			//Check to see if computer is ready to turn on
			if (computer.transform.position.x-this.gameObject.transform.position.x<.01f) {
				
				//Turn on computer
				computerScreen.renderer.material = computerOn;
				
				//Start timer as camera zooms in
				StartCoroutine(Timer());
				
			}
		}
	}
	//Timer
	IEnumerator Timer() {
		//Wait 10 seconds then load menu
		float timeToWait = 10f; 
		yield return new WaitForSeconds(timeToWait);
		
		//Load menu
		Application.LoadLevel(1);
	}
}
