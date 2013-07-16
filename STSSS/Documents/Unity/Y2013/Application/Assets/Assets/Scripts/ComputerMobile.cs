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

public class ComputerMobile : MonoBehaviour {
	
	public GameObject computer;
	public GameObject Player;
	public GameObject joystickMove;
	public GameObject joystickLook;
	public GameObject computerScreen;
	public Material computerOn;
	public Material computerOff;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//Check to see if the player is close to the computer
		if (computer.transform.position.z-Player.transform.position.z<=2 && Mathf.Abs(computer.transform.position.x-Player.transform.position.x)<=1) {
			
			//If the player is within a specific distance the following will happen:
			
			//Audio components on the player will turn off (currently these are the footstep sounds)
			Player.GetComponent<AudioSource>().enabled = false;
			
			//Disable ability to move character
			joystickMove.SetActive(false);
			
			//Disable ability to rotate camera
			joystickLook.SetActive(false);
			
			//Move player to computer using iTween
			//Set position and rotation below to that of the computer and the player will move/rotate to the position specified
			iTween.MoveTo(Player,new Vector3(computer.transform.position.x,0,computer.transform.position.z-1.5f),10);
			iTween.RotateTo(Player,iTween.Hash("rotation",new Vector3(0,Player.transform.position.y,0),"time",10));
			
			//Move camera closer to computer screen automatically using iTween
			//Set position and rotation below to that of the computer and the camera will move/rotate to the position specified
			iTween.RotateTo(this.gameObject,iTween.Hash("rotation",new Vector3(0,0,0),"time",10));
			iTween.MoveTo(this.gameObject,new Vector3(computer.transform.position.x,computer.transform.position.y+.35f,computer.transform.position.z-.5f),10);
			
			//Check to see if computer is ready to turn on (by comparing coordinates of computer and player)
			//If the player is within a certain distance of the computer, the computer will "turn on"
			if (computer.transform.position.z-Player.gameObject.transform.position.z<=1.55f) {
				
				//Turn on computer by changing the texture on screen
				Debug.Log ("Turning on computer");
				computerScreen.renderer.material = computerOn;
				
				//Load level after computer is on and player is within a certain distance
				if (computer.transform.position.z-Player.gameObject.transform.position.z<=1.501f) {
					
					//Load computer menu
					Debug.Log ("Level Load");
					Application.LoadLevel(1);
				}
			}
		}
	}
}
