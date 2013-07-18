using UnityEngine;
using System.Collections;

public class AnimationTest2 : MonoBehaviour {
	
	
	public GameObject leganim;
	public GameObject medcamera;
	public string[] myStrings;
	public GUIText simtext;
	public GameObject legcamera;
	public float x;
	public int swipenumber;
	public int currIndex;

	// Use this for initialization
	void Start () {
		
		swipenumber = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
	
			myStrings= new string[]{"Medial Incision", "Mark Incision", "Expose and free Muscles","Lateral Incision", "Mark Incision", "Incise skin & \nSubcutaneous Tissue", "Perform 'H-cut'; \nwatch for peroneal nerve", "Fasciotomy Complete"};
	
	if (leganim.GetComponent<AnimationTest>().boolean == true && (leganim.GetComponent<LegZoom2>().control == 0 || leganim.GetComponent<AnimationTest>().swipeNumber == 1) ){
			leganim.GetComponent<MegaModifyObject>().enabled = true;
		
		}
	
		if (simtext.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)  && currIndex == 0){
			TextChange();
	
	}
		
			if (leganim.GetComponent<MegaPointCache>().time > 5 && swipenumber < 1 && leganim.GetComponent<LegZoom2>().control == 0) {	
				GetComponent<MegaModifyObject>().enabled = false;
				swipenumber ++;
				leganim.GetComponent<AnimationTest>().boolean = false;
				TextChange();
			}
		
		if (leganim.GetComponent<MegaPointCache>().time > 10 && swipenumber < 2) {	
				GetComponent<MegaModifyObject>().enabled = false;
				swipenumber ++;
				leganim.GetComponent<AnimationTest>().boolean = false;
			}
		
		
		if (leganim.GetComponent<MegaPointCache>().time > 15 && swipenumber < 3) {	
				GetComponent<MegaModifyObject>().enabled = false;
				swipenumber ++;
				leganim.GetComponent<AnimationTest>().boolean = false;
			}
		
		if (leganim.GetComponent<MegaPointCache>().time > 20 && swipenumber < 4) {	
				GetComponent<MegaModifyObject>().enabled = false;
				swipenumber ++;
				leganim.GetComponent<AnimationTest>().boolean = false;
			}
	
		if (leganim.GetComponent<MegaPointCache>().time > 25 && swipenumber < 5) {	
				GetComponent<MegaModifyObject>().enabled = false;
				swipenumber ++;
				leganim.GetComponent<AnimationTest>().boolean = false;
				TextChange();
			}
		
		
			if (simtext.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0) && leganim.GetComponent<LegZoom2>().control == 0 && currIndex == 3){
				medcamera.camera.enabled = false;
				medcamera.SetActive (false);
				legcamera.SetActive( true);
				legcamera.camera.enabled = true;
				TextChange();
	
		}
		
		if (leganim.GetComponent<MegaPointCache>().time > 30 && swipenumber < 6) {	
				GetComponent<MegaModifyObject>().enabled = false;
				swipenumber ++;
				leganim.GetComponent<AnimationTest>().boolean = false;
				TextChange();
			}
		
		if (leganim.GetComponent<MegaPointCache>().time > 35 && swipenumber < 7) {	
				GetComponent<MegaModifyObject>().enabled = false;
				swipenumber ++;
				leganim.GetComponent<AnimationTest>().boolean = false;
			}
		
		if (leganim.GetComponent<MegaPointCache>().time > 40 && swipenumber < 8) {	
				GetComponent<MegaModifyObject>().enabled = false;
				swipenumber ++;
				leganim.GetComponent<AnimationTest>().boolean = false;
				TextChange();
			}
		
		if (leganim.GetComponent<MegaPointCache>().time > 45 && swipenumber < 9) {	
				GetComponent<MegaModifyObject>().enabled = false;
				swipenumber ++;
				leganim.GetComponent<AnimationTest>().boolean = false;
			}
		
		if (leganim.GetComponent<MegaPointCache>().time > 50 && swipenumber < 10) {	
				GetComponent<MegaModifyObject>().enabled = false;
				swipenumber ++;
				leganim.GetComponent<AnimationTest>().boolean = false;
			}
		
		if (leganim.GetComponent<MegaPointCache>().time > 55 && swipenumber <11) {	
				GetComponent<MegaModifyObject>().enabled = false;
				swipenumber ++;
				leganim.GetComponent<AnimationTest>().boolean = false;
				TextChange();
			}
	}	
	
	
	
	
	
	public void TextChange(){
			
			currIndex++;
			simtext.text = myStrings[currIndex];
		}	
	}

