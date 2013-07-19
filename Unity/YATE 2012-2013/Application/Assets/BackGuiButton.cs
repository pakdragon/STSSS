using UnityEngine;
using System.Collections;

public class BackGuiButton : MonoBehaviour {
	
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
	public GameObject player;

	// Use this for initialization
	void Start () {
	
		Screen.showCursor = true;
		step = -1;
	}
	
	// Update is called once per frame
	void Update () {
			if (backbutton.HitTest(Input.mousePosition) && Input.GetMouseButtonUp(0)){
			
			player.transform.position = new Vector3(-4.892138f, 6.965034f, -5.814781f);
			legcamera.camera.enabled =(false);
			legcamera.SetActive(false);
			medcamera.camera.enabled = (true);
			simtest.enabled = true;
			simpract.enabled = true;
			simtext.enabled = false;
			menu.active = false;
			menu.enabled = false;
			steps.enabled = false;
			leganim.GetComponent<LegZoom2>().control = -1;
			leganim.GetComponent<AnimationTest2>().currIndex = 0;
			step = 0;
			simtext.text = leganim.GetComponent<AnimationTest2>().myStrings[leganim.GetComponent<AnimationTest2>().currIndex];
			steps.guiTexture.texture = leganim.GetComponent<AnimationTest>().pracstep[step];
			//leganim.GetComponent<MegaPointCache>().time = 11;
			leganim.GetComponent<LegZoom2>().control = -1;
			//leganim.GetComponent<AnimationTest>().swipeNumber = 0;
			leganim.GetComponent<MegaModifyObject>().enabled = true;
			leganim.GetComponent<MegaPointCache>().time = 0 ;
			leganim.GetComponent<MegaModifyObject>().enabled = false;
			leganim.GetComponent<LegZoom2>().x = 0;
			
			//Application.LoadLevel (0);
		}
		
		
   		
	
	
	}

}