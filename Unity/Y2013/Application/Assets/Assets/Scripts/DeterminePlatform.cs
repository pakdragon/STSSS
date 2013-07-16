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

public class DeterminePlatform : MonoBehaviour {
	
	public GameObject PCController;
	public GameObject MobileController;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//Check to see if the system is running Android or iOS
		if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer) {
			
			//If so, turn off the PC character controller
			PCController.SetActive(false);
		}
		
		else {
			
			//Otherwise, turn off the mobile character controller
			MobileController.SetActive(false);
		}
	}
}
