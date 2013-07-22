using UnityEngine;
using System.Collections;

public class AnimationTest2 : MonoBehaviour {
	
	
	public GameObject leganim;
	public GameObject scalpel;
	public GameObject scissors;
	public GameObject marker;
	public GameObject fascia;
	public GameObject muscle;
	public GameObject medcamera;
	public bool test2;
	public string[] myStrings;
	public GUIText simtext;
	public GameObject legcamera;
	public float m;
	public float n;
	
	public int another;
	public int currIndex;

	// Use this for initialization
	void Start () {
		
		
		m = 0;
		n =0;
		
		another = -1;
		//Gumbo = leganim.GetComponent<LegZoom2>().step;
		legcamera.transform.position = new Vector3(4.54f, 9.434f, -3.932f);
		marker.GetComponent<MegaModifyObject>().enabled = false;
		muscle.GetComponent<MegaModifyObject>().enabled = false;
		fascia.GetComponent<MegaModifyObject>().enabled = false;
		scalpel.SetActive(false);
		scissors.SetActive(false);
	
		/*theCache = leganim.GetComponent<MegaPointCache>();
		theObject = GetComponent<MegaModifyObject>();
		StartCoroutine(TimeStop());*/
	}
	
	
	
		
		
		
	// Update is called once per frame
	void Update () {
		
		Vector3 StartPos = new Vector3(4.54f, 9.434f, -3.932f);
		Vector3 EndPos = new Vector3 (6.1f, 9.1f, -4.017f);
		
		Vector3 StartPos2 = new Vector3(7.191603f, 8.878978f, -3.069204f);
		Vector3 EndPos2 = new Vector3 (7.118078f, 8.703024f, -2.140638f);
		
		Vector3 Start = new Vector3(7.24195f, 8.81769f, -2.6684f);
		Vector3 End = new Vector3(7.26267f,8.80465f, -2.0344f);
		
		Vector3 Sciss = new Vector3(7.01448f, 8.84510f, -2.7018f);
		Vector3 EndSciss = new Vector3(7.01811f, 8.83518f, -2.5317f);
		
		Vector3 NewEnd = new Vector3(7.018448f, 8.85037f, -2.922752f);
		
		Quaternion First = new Quaternion(346.3763f, 139.1233f, 170.0109f,0f);
		Quaternion Last = new Quaternion(6.6962f, 39.50874f, 195.482f,360f);
		
		if (simtext.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)  && currIndex == 0 && simtext.enabled == true){
			control ();
			TextChange();
		}
		
		
		if (test2 == true && another <= 1 && simtext.enabled == true){
			marker.GetComponent<MegaModifyObject>().enabled = true;
			another = 1;
		
		}
			
			if (marker.GetComponent<MegaPointCache>().time > 4f && another <= 1 && simtext.enabled == true) {	
				control ();
				marker.GetComponent<MegaModifyObject>().enabled = false;
				test2 = false;
				//leganim.GetComponent<MegaPointCache>().time = 2.1f;
				another++;
				
				TextChange();
			
			}
			
		
		
		if (test2 == true && another == 2 && simtext.enabled == true){
			leganim.GetComponent<MegaModifyObject>().enabled = true;
			leganim.GetComponent<MegaPointCache>().time = 4f;
			marker.GetComponent<MegaModifyObject>().enabled = true;
			//scalpel.SetActive(true);
			scalpel.transform.position = StartPos2;
			m = 0;
			another++;
		}
		
		
		if (another == 3 && simtext.enabled == true ){
			
			scalpel.transform.position = StartPos2;
			scalpel.SetActive(true);
			//print ("I'm back again");
			scalpel.transform.position = Vector3.Lerp (StartPos2, EndPos2, m);
				if (m < 1){
				m = m + .05f;
			}
		}
			
		
		if (marker.GetComponent<MegaPointCache>().time > 6f  && another == 3 && simtext.enabled == true) {
			control ();	
			marker.GetComponent<MegaModifyObject>().enabled = false;
			
			
		}
			
			
			
			if (leganim.GetComponent<MegaPointCache>().time > 6f  && another == 3 && simtext.enabled == true) {	
			control ();	
			leganim.GetComponent<MegaModifyObject>().enabled = false;
			scalpel.SetActive(false);
				
				test2 = false;
				another ++;
				TextChange();
			
			}
		
	if (test2 == true && another == 4 && simtext.enabled == true){
			fascia.GetComponent<MegaModifyObject>().enabled = true;
			fascia.GetComponent<MegaPointCache>().time = 6f;
			scalpel.transform.position = new Vector3(7.24195f, 8.81769f, -2.6684f);
			scalpel.SetActive(true);
			m = 0;
			another ++;
		
		}
	
		
		if (fascia.GetComponent<MegaPointCache>().time > 6.3 && simtext.enabled == true){
			
			scalpel.SetActive(false);
		}
		
		if (fascia.GetComponent<MegaPointCache>().time > 6.3f && fascia.GetComponent<MegaPointCache>().time < 6.7f && simtext.enabled == true){
			
			scissors.transform.position = Sciss;
			scissors.transform.rotation = First;
			scissors.SetActive(true);
			n = 0;
		}
		
		
		if (fascia.GetComponent<MegaPointCache>().time > 6.4f && fascia.GetComponent<MegaPointCache>().time < 7.6f && simtext.enabled == true){
			
			scissors.transform.position = Vector3.Lerp (Sciss, EndSciss, n);
				if (n < 1){
				n = n + .3f;
			}
			
		}
		
		if (fascia.GetComponent<MegaPointCache>().time > 7.6f && fascia.GetComponent<MegaPointCache>().time < 9f && simtext.enabled == true){
			
			scissors.transform.rotation = Last; //Quaternion.Lerp (First, Last, y);
			scissors.transform.position = Vector3.Lerp (EndSciss, NewEnd, m);
				if (m < 1){
				m = m + .3f;
			}
			
		}
		
		
			if (fascia.GetComponent<MegaPointCache>().time > 9  && another == 5 && simtext.enabled == true) {	
			control ();	
			fascia.GetComponent<MegaModifyObject>().enabled = false;
				test2 = false;
				scissors.SetActive(false);
				another++;
				//leganim.GetComponent<MegaPointCache>().time = 11f;
				TextChange();
				scissors.SetActive(false);
			
			}
		
		if (test2 == true && another == 6 && simtext.enabled == true){
			muscle.GetComponent<MegaModifyObject>().enabled = true;
			muscle.GetComponent<MegaPointCache>().time = 5f;
			
			another++;
		
		}
		
				if (muscle.GetComponent<MegaPointCache>().time > 9  && another == 7 && simtext.enabled == true) {	
			control ();	
			muscle.GetComponent<MegaModifyObject>().enabled = false;
				test2 = false;
				another++;
				//leganim.GetComponent<MegaPointCache>().time = 11f;
				TextChange();
			}
		
		
			if (simtext.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0) && leganim.GetComponent<LegZoom2>().control == 0 && currIndex == 3 && simtext.enabled == true){
				medcamera.camera.enabled = false;
				medcamera.SetActive (false);
				legcamera.SetActive( true);
				legcamera.camera.enabled = true;
				TextChange();
	
		}
		
	/*	if (leganim.GetComponent<MegaPointCache>().time > 30 ) {	
				GetComponent<MegaModifyObject>().enabled = false;
				//swipenumber ++;
				leganim.GetComponent<AnimationTest>().boolean = false;
				TextChange();
			}
		
		if (leganim.GetComponent<MegaPointCache>().time > 35 ) {	
				GetComponent<MegaModifyObject>().enabled = false;
				//swipenumber ++;
				leganim.GetComponent<AnimationTest>().boolean = false;
			}
		
		if (leganim.GetComponent<MegaPointCache>().time > 40 ) {	
				GetComponent<MegaModifyObject>().enabled = false;
				//swipenumber ++;
				leganim.GetComponent<AnimationTest>().boolean = false;
				TextChange();
			}
		
		if (leganim.GetComponent<MegaPointCache>().time > 45 ) {	
				GetComponent<MegaModifyObject>().enabled = false;
				//swipenumber ++;
				leganim.GetComponent<AnimationTest>().boolean = false;
			}
		
		if (leganim.GetComponent<MegaPointCache>().time > 50 ) {	
				GetComponent<MegaModifyObject>().enabled = false;
				//swipenumber ++;
				leganim.GetComponent<AnimationTest>().boolean = false;
			}
		
		if (leganim.GetComponent<MegaPointCache>().time > 55 ) {	
				GetComponent<MegaModifyObject>().enabled = false;
				//swipenumber ++;
				leganim.GetComponent<AnimationTest>().boolean = false;
				TextChange();
			} */
	}	
	
	public void control(){
		
		leganim.GetComponent<LegZoom2>().control = 0;
	}
	
	
	public void test2Change(){
		
		test2 = true;
	}
	
	
	public void TextChange(){
			myStrings= new string[]{"Medial Incision", "Mark Incision", "Expose and free Muscles","Lateral Incision", "Mark Incision", "Incise skin & \nSubcutaneous Tissue", "Perform 'H-cut'; \nwatch for peroneal nerve", "Fasciotomy Complete"};
			currIndex++;
			simtext.text = myStrings[currIndex];
		}	
	}

