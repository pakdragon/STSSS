using UnityEngine;
using System.Collections;

public class MenuButton : MonoBehaviour {
	
	
	public GameObject legcamera;
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
		
		
		/*if (medcamera.GetComponent<LegZoom2>().menu.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)){
			
			medcamera.GetComponent<LegZoom2>().control = -1;
			legcamera.SetActive(false);
			medcamera.SetActive(true);
			medcamera.GetComponent<LegZoom2>().simtest.enabled = true;
			medcamera.GetComponent<LegZoom2>().simpract.enabled = true;
			medcamera.GetComponent<LegZoom2>().simtext.enabled = false;
			medcamera.GetComponent<LegZoom2>().menu.enabled = false;
			medcamera.GetComponent<LegZoom2>().steps.enabled = false;
			medcamera.GetComponent<LegZoom2>().currIndex = 0;
			medcamera.GetComponent<LegZoom2>().step = 0;
			legcamera.GetComponent<LegZoom2>().step = 0;
			//steps.guiTexture.texture = medcamera.GetComponent<AnimationTest>().pracstep[medcamera.GetComponent<LegZoom2>().step];
			medcamera.GetComponent<LegZoom2>().simtext.text = medcamera.GetComponent<LegZoom2>().myStrings[medcamera.GetComponent<LegZoom2>().currIndex];
		
			
		}*/
		
		
		
			if (menu.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0) &&  (leganim.GetComponent<LegZoom2>().control == 0 ||  leganim.GetComponent<LegZoom2>().control == 1)){
			
			legcamera.SetActive(false);
			legcamera.camera.enabled = false;
			medcamera.SetActive(true);
			medcamera.camera.enabled = true;
			simtest.enabled = true;
			simpract.enabled = true;
			simtext.enabled = false;
			menu.active = false;
			menu.enabled = false;
			steps.enabled = false;
			steps.active = false;
			leganim.GetComponent<SwipeTest>().enabled = false;
			leganim.GetComponent<AnimationTest2>().currIndex = 0;
			step = 0;
			leganim.GetComponent<AnimationTest>().swipeNumber = 0;
			leganim.GetComponent<AnimationTest2>().swipenumber = 0;
			simtext.text = leganim.GetComponent<AnimationTest2>().myStrings[leganim.GetComponent<AnimationTest2>().currIndex];
			steps.guiTexture.texture = leganim.GetComponent<AnimationTest>().pracstep[step];
			//leganim.GetComponent<MegaPointCache>().time = 11;
			leganim.GetComponent<LegZoom2>().control = -1;
			//leganim.GetComponent<AnimationTest>().swipeNumber = 0;
			leganim.GetComponent<MegaModifyObject>().enabled = true;
			leganim.GetComponent<MegaPointCache>().time = 0 ;
			leganim.GetComponent<MegaModifyObject>().enabled = false;
		}
		
		
		/*if (leganim.GetComponent<MegaPointCache>().time == 62){
			
			leganim.GetComponent<MegaPointCache>().time = 0;
			leganim.GetComponent<MegaModifyObject>().enabled = false;
		}*/
	}
}
