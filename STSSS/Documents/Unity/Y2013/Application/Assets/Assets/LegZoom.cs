using UnityEngine;
using System.Collections;

public class LegZoom : MonoBehaviour {
	
	public GameObject leg;
	public GameObject player;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(((leg.transform.position.x)-(player.transform.position.x)) <= 2.6f && (((leg.transform.position.z)-(player.transform.position.z)) >= -1f||((leg.transform.position.z)-(player.transform.position.z)) <=3.4f)) {
		
			Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, 30, Time.deltaTime*1);
		}
			
		else{
				Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, 60, Time.deltaTime*5);
			}
		
	}
		
}
