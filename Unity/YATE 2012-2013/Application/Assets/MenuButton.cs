using UnityEngine;
using System.Collections;

public class MenuButton : MonoBehaviour {
	
	
	public GameObject legcamera;
	public GameObject scalpel;
	public GameObject empty;
	public GameObject medcamera;
	public GUITexture backbutton;
	public GUITexture simtest;
	public GUITexture simpract;
	public GUIText simtext;
	public GUITexture menu;
	//public string[] myStrings; 
	public int currIndex;
	public GUITexture steps;
	public GameObject leganim;
	public GameObject marker;
	public GameObject muscle;
	public GameObject fascia;
	//public Texture2D[] pracstep = new Texture2D[25];
	//public int step= 0;
	//public int control;
	public int step;

	// Use this for initialization
	void Start () {
		
		step = -1;
		
	
	}
	
	// Update is called once per frame
	void Update () {
		
		
	
		
		
		
			if (menu.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0) &&  (leganim.GetComponent<LegZoom2>().control == 0 ||  leganim.GetComponent<LegZoom2>().control == 1)){
			
			empty.SetActive(true);
			legcamera.SetActive(false);
			legcamera.camera.enabled = false;
			medcamera.SetActive(true);
			medcamera.camera.enabled = true;
			simtest.enabled = true;
			simpract.active = false;
			simpract.enabled = true;
			simtext.enabled = false;
			scalpel.SetActive(false);
			scalpel.transform.position = new Vector3(7.26665f, 8.83102f, -3.0001f);
			menu.active = false;
			menu.enabled = false;
			steps.enabled = false;
			steps.active = false;
			leganim.GetComponent<SwipeTest>().enabled = false;
			leganim.GetComponent<AnimationTest2>().currIndex = 0;
			step = 0;
			//leganim.GetComponent<AnimationTest>().swipeNumber = -1;
			//leganim.GetComponent<AnimationTest2>().swipenumber = -1;
			//simtext.text = leganim.GetComponent<AnimationTest2>().myStrings[leganim.GetComponent<AnimationTest2>().currIndex];
			steps.guiTexture.texture = leganim.GetComponent<AnimationTest>().pracstep[step];
			//leganim.GetComponent<LegZoom2>().control = -1;
			leganim.GetComponent<MegaModifyObject>().enabled = true;
			leganim.GetComponent<MegaPointCache>().time = 0 ;
			leganim.GetComponent<MegaModifyObject>().enabled = false;
			resetAnim();
			Number();
		}
		
	
		/*if (leganim.GetComponent<MegaPointCache>().time == 62){
			
			leganim.GetComponent<MegaPointCache>().time = 0;
			leganim.GetComponent<MegaModifyObject>().enabled = false;
		}*/
	
	
		
		if (leganim.GetComponent<MegaPointCache>().time > 10.1f){
	
			
			leganim.GetComponent<MegaModifyObject>().enabled = false;
			leganim.GetComponent<MegaPointCache>().time = 0f;
			marker.GetComponent<MegaPointCache>().time = 0f;
			
			Number();
		}
		
		if (muscle.GetComponent<MegaPointCache>().time > 11f){
	
			
			muscle.GetComponent<MegaModifyObject>().enabled = false;
			muscle.GetComponent<MegaPointCache>().time = 0f;
			Number();
		}
		
		if (marker.GetComponent<MegaPointCache>().time > 10.1f){
	
			
			marker.GetComponent<MegaModifyObject>().enabled = false;
			marker.GetComponent<MegaPointCache>().time = 0f;
			Number ();
		}
		
		if (fascia.GetComponent<MegaPointCache>().time > 11f){
	
			
			fascia.GetComponent<MegaModifyObject>().enabled = false;
			fascia.GetComponent<MegaPointCache>().time = 0f;
			Number();
		}
	
	}
		 void resetAnim(){
		
		//muscle.GetComponent<MegaPointCache>().SetAnim(10.1f);
		//leganim.GetComponent<MegaPointCache>().SetAnim(10.1f);
		//fascia.GetComponent<MegaPointCache>().SetAnim(10.1f);
		//muscle.GetComponent<MegaPointCache>().SetAnim(10.1f);
		//print ("HELLLOEOIEOEOEOEO");
		
		
	//if (menu.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0) &&  (leganim.GetComponent<LegZoom2>().control == 0 ||  leganim.GetComponent<LegZoom2>().control == 1)){	
		leganim.GetComponent<MegaPointCache>().time = 9.9f;
		marker.GetComponent<MegaPointCache>().time = 9.9f;
		muscle.GetComponent<MegaPointCache>().time = 9.9f;
		fascia.GetComponent<MegaPointCache>().time = 9.9f;
		leganim.GetComponent<MegaModifyObject>().enabled = true;
		marker.GetComponent<MegaModifyObject>().enabled = true;
		muscle.GetComponent<MegaModifyObject>().enabled = true;
		fascia.GetComponent<MegaModifyObject>().enabled = true;
	}
	
	public void Number(){
		leganim.GetComponent<AnimationTest>().swipeNumber = -1;
	}
	
		
}
