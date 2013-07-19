using UnityEngine;
using System.Collections;

public class Scalpel : MonoBehaviour {
	
	public GameObject scalpel;
	public GameObject leganim;
	public float y;
	

	// Use this for initialization
	void Start () {
		
		
		scalpel.transform.position = new Vector3(7.26665f, 8.83102f, -3.0001f);
		scalpel.SetActive(false);
		y = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
		//scalpel.SetActive(false);
		
		Vector3 StartPos = new Vector3(7.26665f, 8.83102f, -3.0001f);
		Vector3 EndPos = new Vector3 (7.22076f, 8.72499f, -2.0344f);
		
		Vector3 Start = new Vector3(7.24195f, 8.81769f, -2.6684f);
		Vector3 End = new Vector3(7.237984f,8.796801f, -2.5532f);
		
		
		if (leganim.GetComponent<AnimationTest>().swipeNumber == 3 && leganim.GetComponent<MegaModifyObject>().enabled == true){
			
			//scalpel.SetActive(true);
			print ("I'm back again");
			scalpel.transform.position = Vector3.Lerp (StartPos, EndPos, y);
				if (y < 1){
				y = y + .05f;
				//scalpel.SetActive(false);
				//scalpel.transform.position = StartPos;
			}
		}
			
			if(leganim.GetComponent<AnimationTest>().swipeNumber == 5){
					print ("I am inside");
					scalpel.transform.position = new Vector3(7.24195f, 8.81769f, -2.6684f);
					//scalpel.SetActive(true);
					scalpel.transform.position = Vector3.Lerp (Start, End, y);
					//scalpel.SetActive(false);
			if (y < 1){
				y = y + .05f;
				//scalpel.SetActive(false);
				//scalpel.transform.position = StartPos;
			}
				}
			
	
			
	
			
			
		/*else{
				
			scalpel.SetActive(false);
			scalpel.transform.position = new Vector3(7.26665f, 8.83102f, -3.0001f);
			y = 0;
			}*/
		}
	}

