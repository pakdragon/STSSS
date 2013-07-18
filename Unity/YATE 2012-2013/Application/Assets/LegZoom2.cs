using UnityEngine;
using System.Collections;



public class LegZoom2 : MonoBehaviour {
	
	
	public GameObject joystickMove;
	public GameObject joystickRotate;
	public GameObject body;
	public GameObject player;
	public GameObject legcamera;
	public GameObject medcamera;
	public GUITexture backbutton;
	public GUITexture simtest;
	public GUITexture simpract;
	public GUIText simtext;
	public GUITexture menu;
	public string[] myStrings; 
	public int currIndex;
	public GUITexture steps;
	public GameObject leganim;
	public GameObject empty;
	//public Texture2D[] pracstep = new Texture2D[25];
	//public int step= 0;
	public int control;
	public float x;
	
	

	
	// Use this for initialization
	void Start () {
		
		control = -1;
		//step = 0;
		screenResize();
		leganim.GetComponent<MegaModifyObject>().enabled = false;
		leganim.GetComponent<SwipeTest>().enabled = false;
		x=0;
		
		Screen.showCursor = true;
	
	}
	
	
	// Update is called once per frame
	void Update () {
	
		Vector3 StartPos = new Vector3(8.63688f, 9.457705f, -3.06230f);
		Vector3 EndPos = new Vector3(7.80175f, 8.970406f, -2.89487f);
		//Vector3 EndPos = new Vector3 (6.1f, 9.1f, -4.017f);
		medcamera.transform.position = new Vector3(8.63688f, 9.457705f, -3.06230f);
		
		

		
	if(((body.transform.position.x)-(player.transform.position.x)) <= 3.2f && ((body.transform.position.x)-(player.transform.position.x)) >= -5f && ((body.transform.position.z)-(player.transform.position.z)) <= 8f && ((body.transform.position.z)-(player.transform.position.z)) >= -2.8f) {
		
		medcamera.SetActive (true);
		medcamera.camera.enabled = (true);
		
		simtest.active = true;
		
		simpract.active = true;
		medcamera.transform.position = Vector3.Lerp (StartPos, EndPos, x);
			if (x < 1){
				x = x + .08f;
			}
			
		player.GetComponent<AudioSource>().enabled = false;
		joystickMove.SetActive ( false);
		joystickRotate.SetActive ( false);
		player.SetActive (false);
		
		}
		
	else { 
			x = 0.00f;
			player.SetActive(true);
			joystickMove.SetActive ( true);
			joystickRotate.SetActive ( true);
			medcamera.camera.enabled = (false);
			medcamera.SetActive (false);
			medcamera.transform.position = new Vector3(8.912951f, 9.702024f, -3.959019f);
			legcamera.camera.enabled = false;
			legcamera.SetActive(false);
			legcamera.transform.position = new Vector3(6.1f, 9.1f, -4.017f);
			simtest.enabled = true;
			simtest.active = false;
			simpract.enabled = true;
			simpract.active = false;
			simtext.enabled = false;
			menu.enabled = false;
			menu.active = false;
			steps.active = false;
			steps.enabled = false;
			}
			
		if (simtest.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)){
			
			empty.SetActive (false);
			simtext.enabled = true;
			simtext.active = true;
			simtest.enabled = false;
			simpract.enabled = false;
			legcamera.SetActive (false);
			legcamera.camera.enabled = false;
			menu.active = true;
			menu.enabled = true;
			control = 0;
			leganim.GetComponent<SwipeTest>().enabled = true;
		
		}
		
		if(simpract.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)&& control <= 1){
			empty.SetActive(false);
			empty.active = false;
			simtest.enabled = false;
			simtest.active = false;
			simpract.active = false;
			simpract.enabled = false;
			simtext.enabled = false;
			control = 3;
			menu.active = true;
			menu.enabled = true;
			steps.enabled = true;
			steps.active = true;
			leganim.GetComponent<SwipeTest>().enabled = true;
			leganim.GetComponent<AnimationTest>().swipeNumber = -1;
			control = 0;
			leganim.GetComponent<MenuButton>().step = 0;
			steps.guiTexture.texture = leganim.GetComponent<AnimationTest>().pracstep[leganim.GetComponent<MenuButton>().step];
		}
		else{
			control = -1;
		}
		
		if (steps.enabled == true){
			control = 1;
			simtext.enabled = false;
		}
		
		//if (control == 1){
		//	steps.enabled = true;
		//	simtext.enabled = false;
		//}
		
		else{
			steps.enabled =false;
		}
			
		
		/*if (menu.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0) && control == 1){
			
			legcamera.SetActive(false);
			medcamera.SetActive(true);
			simtest.enabled = true;
			simpract.enabled = true;
			simtext.enabled = false;
			menu.active = false;
			menu.enabled = false;
			steps.enabled = false;
			currIndex = 0;
			step = 0;
			simtext.text = myStrings[currIndex];
			//steps.guiTexture.texture = leganim.GetComponent<AnimationTest>().pracstep[step];
			leganim.GetComponent<MegaPointCache>().time = 11;
			control = -1;
		}*/
		
		//if (leganim.GetComponent<MegaPointCache>().time == 11){
			
			//leganim.GetComponent<MegaPointCache>().time = 0;
		//}
		
		
		
	/*	if (steps.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0) && control == 1){
			
			
			step++;
			steps.guiTexture.texture = pracstep[step];
	
			}*/
		
	 	/*Vector3 Start = new Vector3(6.1f, 9.1f, -4.017f);
		Vector3 End = new Vector3(7.792827f, 9.159904f, -4.073456f);
		Quaternion StartRot = new Quaternion(11.57439f, 93.0267f,-360,0);
		Quaternion EndRot = new Quaternion(11.57439f, 270,0,0);
		
		
		
		if (step == 14){
			
			legcamera.transform.position = Vector3.Lerp (Start, End, Time.deltaTime * 2);
			legcamera.transform.rotation = Quaternion.Lerp(StartRot, EndRot, Time.deltaTime *2);
		}
		*/
	
		
		
	/*myStrings= new string[]{"Lateral Incision", "Mark Incision", "Incise skin & \nSubcutaneous Tissue", "Perform 'H-cut'; \nwatch for peroneal nerve", "Lateral Incision Complete", "Medial Incision", "Mark Incision", "Expose and free Muscles", "Fasciotomy Complete"};
		
		if (simtext.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0) && control == 0){
			
			currIndex++;
			simtext.text = myStrings[currIndex];
		}	*/
			
		
		
		
		
	
			
			//legcamera.transform.position = Vector3.Lerp (Start, End, Time.deltaTime * 2);
			//legcamera.transform.rotation = Quaternion.Lerp(StartRot, EndRot, Time.deltaTime *2);
}

	void screenResize(){

		backbutton.pixelInset = new Rect((470f/512f)*Screen.width, (20f/512f)*Screen.width, (6f/100f)*Screen.width, (10f/100f)*Screen.height);
		simtest.pixelInset = new Rect((350f/512f)*Screen.width, (150f/512f)*Screen.width, (30f/100f)*Screen.width, (20f/100f)*Screen.height);
		simpract.pixelInset = new Rect((10f/512f)*Screen.width, (150f/512f)*Screen.width, (30f/100f)*Screen.width, (20f/100f)*Screen.height);
		menu.pixelInset = new Rect((15f/512f)*Screen.width, (15f/512f)*Screen.width, (30f/100f)*Screen.width, (20f/100f)*Screen.height);
		steps.pixelInset = new Rect ((150f/512f)*Screen.width, (150f/512f)*Screen.width, (50f/100f)*Screen.width, (40f/100f)*Screen.height);
		//simtext.pixelInset = new Rect((20f/512f)*Screen.width, (30f/512f)*Screen.width, (12.5f/100f)*Screen.width, (12.5f/100f)*Screen.height);
		
		
	}

}
			
		
	
			
		
	
		
		
		
	

		


			
	
