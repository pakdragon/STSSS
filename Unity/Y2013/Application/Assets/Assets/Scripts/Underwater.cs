/* Save the Soldier Surgical Simulation
 * 
 * Year/Summer at the Edge 2012-2013
 * 
 * Dr. Rob Williams
 * 
 * Tyler Maschino
 * 
 *-----------------------------------------*/
//Note: This script was made just to experiment with fog
//		and it is not crucial to the project

using UnityEngine;
using System.Collections;
 
public class Underwater : MonoBehaviour {
 
public Transform Player;
public AudioClip wavesSound;
public AudioSource waves;
public bool isPLaying;
public GameObject character;
private Color fog;
	
	void Start() {
		
		//Set the wave sound to be the current clip
		waves.clip = wavesSound;
		
		//Set default fog color 
		fog  = RenderSettings.fogColor; //(.502,.502,.502,.502)
		
		//Play the wave sound
		waves.Play();
		
	}
	
	void Update() {
		
		//Store bool value of whether the clip is playing
		isPLaying = waves.isPlaying;
		
		//Check to see if the player is below the waves
		if (Player.position.y<(this.transform.position.y+.5)) {
			
			//Set the fog to be exponential
			RenderSettings.fogMode = FogMode.Exponential;
			
			//Make the fog more dense until it reaches .06
			if (RenderSettings.fogDensity<.06f) {
				RenderSettings.fogDensity +=.005f;
			}
			
		}
 		
		//The player is above the waves
		else {
			
			//Set the fog to be exponentialSquared
			RenderSettings.fogMode = FogMode.ExponentialSquared;
			
			//Make the fog less dense until it reaches 0
			if (RenderSettings.fogDensity>0.00f) {
				RenderSettings.fogDensity -= 0.005f;
			}
			
			//Set the fog to be the default color
			RenderSettings.fogColor = fog;
 
       }
    }
 
}