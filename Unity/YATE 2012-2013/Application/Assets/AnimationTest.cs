using UnityEngine;
using System.Collections;

public class AnimationTest : MonoBehaviour {
	
	public GameObject leganim;
	public GameObject scalpel;
	public GameObject scissors;
	public GameObject marker;
	public GameObject fascia;
	public GameObject muscle;
	public GameObject medcamera;
	public bool boolean = false;
	public Texture2D[] pracstep = new Texture2D[25];
	//public int Gumbo;
	public GUITexture steps;
	public GameObject legcamera;
	public float x;
	public float y;
	public float z;
	
	public int swipeNumber;
	//public AnimationTest booleanChange;
	/*private float intervalTime = 2.0f;
	private MegaPointCache theCache;
	private MegaModifyObject theObject;
	public float IntervalTime
	{
		get{return intervalTime; }
		set { intervalTime = value;}
	}*/
	
	// Use this for initialization
	void Start () {
		
		y = 0;
		z =0;
		swipeNumber = -1;
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
		
		Vector3 NewEnd = new Vector3(7.014016f, 8.89521f, -3.06123f);
		
		Quaternion First = new Quaternion(346.3763f, 139.1233f, 170.0109f,0f);
		Quaternion Last = new Quaternion(6.6962f, 39.50874f, 195.482f,360f);
		
		if (steps.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)  && (leganim.GetComponent<MenuButton>().step == 0 /*|| leganim.GetComponent<MenuButton>().step == 1*/ )){
			control ();
			guiChange();
		}
		
		
		if (boolean == true && swipeNumber <= 1){
			marker.GetComponent<MegaModifyObject>().enabled = true;
			swipeNumber = 1;
		
		}
			
			if (marker.GetComponent<MegaPointCache>().time > 4f && swipeNumber <= 1) {	
				control ();
				marker.GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				//leganim.GetComponent<MegaPointCache>().time = 2.1f;
				swipeNumber++;
				
				guiChange();
			
			}
			
		
		
		if (boolean == true && swipeNumber == 2){
			leganim.GetComponent<MegaModifyObject>().enabled = true;
			leganim.GetComponent<MegaPointCache>().time = 4f;
			marker.GetComponent<MegaModifyObject>().enabled = true;
			//scalpel.SetActive(true);
			scalpel.transform.position = StartPos;
			y = 0;
			swipeNumber++;
		}
		
		
		if (leganim.GetComponent<AnimationTest>().swipeNumber == 3 ){
			
			scalpel.SetActive(true);
			print ("I'm back again");
			scalpel.transform.position = Vector3.Lerp (StartPos2, EndPos2, y);
				if (y < 1){
				y = y + .05f;
			}
		}
			
		
		if (marker.GetComponent<MegaPointCache>().time > 6f  && swipeNumber == 3 ) {
			control ();	
			marker.GetComponent<MegaModifyObject>().enabled = false;
			
			
		}
			
			
			
			if (leganim.GetComponent<MegaPointCache>().time > 6f  && swipeNumber == 3) {	
			control ();	
			leganim.GetComponent<MegaModifyObject>().enabled = false;
			scalpel.SetActive(false);
				
				boolean = false;
				swipeNumber ++;
				guiChange();
			
			}
		
	if (boolean == true && swipeNumber == 4){
			fascia.GetComponent<MegaModifyObject>().enabled = true;
			fascia.GetComponent<MegaPointCache>().time = 6f;
			scalpel.transform.position = new Vector3(7.24195f, 8.81769f, -2.6684f);
			scalpel.SetActive(true);
			y = 0;
			swipeNumber ++;
		
		}
	
		
		if (fascia.GetComponent<MegaPointCache>().time > 6.3){
			
			scalpel.SetActive(false);
		}
		
		if (fascia.GetComponent<MegaPointCache>().time > 6.3f && fascia.GetComponent<MegaPointCache>().time < 6.4f){
			
			scissors.transform.position = Sciss;
			scissors.transform.rotation = First;
			scissors.SetActive(true);
			z = 0;
		}
		
		
		if (fascia.GetComponent<MegaPointCache>().time > 6.4f && fascia.GetComponent<MegaPointCache>().time < 7.6f){
			
			scissors.transform.position = Vector3.Lerp (Sciss, EndSciss, z);
				if (z < 1){
				z = z + .3f;
			}
			
		}
		
		if (fascia.GetComponent<MegaPointCache>().time > 7.6f && fascia.GetComponent<MegaPointCache>().time < 9f){
			
			scissors.transform.rotation = Last; //Quaternion.Lerp (First, Last, y);
			scissors.transform.position = Vector3.Lerp (EndSciss, NewEnd, y);
				if (y < 1){
				y = y + .3f;
			}
			
		}
		
		
			if (fascia.GetComponent<MegaPointCache>().time > 9  && swipeNumber == 5) {	
			control ();	
			fascia.GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				scissors.SetActive(false);
				swipeNumber++;
				//leganim.GetComponent<MegaPointCache>().time = 11f;
				guiChange();
				scissors.SetActive(false);
			
			}
		
		if (boolean == true && swipeNumber == 6){
			muscle.GetComponent<MegaModifyObject>().enabled = true;
			muscle.GetComponent<MegaPointCache>().time = 5f;
			
			swipeNumber++;
		
		}
		
				if (muscle.GetComponent<MegaPointCache>().time > 9  && swipeNumber == 7) {	
			control ();	
			muscle.GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				swipeNumber++;
				//leganim.GetComponent<MegaPointCache>().time = 11f;
				guiChange();
			}
		
		/*	if (leganim.GetComponent<MegaPointCache>().time >= 25  && swipeNumber < 5) {	
				GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				swipeNumber++;
				//leganim.GetComponent<MegaPointCache>().time = 11f;
				guiChange();
			}
		
			if (leganim.GetComponent<MegaPointCache>().time >= 30  && swipeNumber < 6) {	
				GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				swipeNumber++;
				//leganim.GetComponent<MegaPointCache>().time = 11f;
				guiChange();
			}
		
		if (leganim.GetComponent<MegaPointCache>().time >= 35  && swipeNumber < 7) {	
				GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				swipeNumber++;
				//leganim.GetComponent<MegaPointCache>().time = 11f;
				guiChange();
			}
			if (leganim.GetComponent<MegaPointCache>().time >= 40  && swipeNumber < 8) {	
				GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				swipeNumber++;
				//leganim.GetComponent<MegaPointCache>().time = 11f;
				guiChange();
			}
			if (leganim.GetComponent<MegaPointCache>().time >= 45  && swipeNumber < 9) {	
				GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				swipeNumber++;
				//leganim.GetComponent<MegaPointCache>().time = 11f;
				guiChange();
			}
			if (leganim.GetComponent<MegaPointCache>().time >= 50  && swipeNumber < 10) {	
				GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				swipeNumber++;
				//leganim.GetComponent<MegaPointCache>().time = 11f;
				guiChange();
			}
			if (leganim.GetComponent<MegaPointCache>().time >= 55  && swipeNumber < 11) {	
				GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				swipeNumber++;
				//leganim.GetComponent<MegaPointCache>().time = 11f;
				guiChange();
			}
			if (leganim.GetComponent<MegaPointCache>().time >= 60  && swipeNumber < 12) {	
				GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				swipeNumber++;
				//leganim.GetComponent<MegaPointCache>().time = 11f;
				guiChange();*/
			
		if (steps.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0) && leganim.GetComponent<MenuButton>().step == 12){
			medcamera.camera.enabled = false;
			medcamera.SetActive (false);
			legcamera.SetActive( true);
			legcamera.camera.enabled = true;
			/*legcamera.transform.position = Vector3.Lerp (StartPos, EndPos, x);
			if (x < 1){
				x = x + .08f;
			}*/
			
			guiChange();
		}
		
	/*	if (leganim.GetComponent<MegaPointCache>().time >= 65  && swipeNumber < 13) {	
				GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				swipeNumber++;
				//leganim.GetComponent<MegaPointCache>().time = 11f;
				guiChange();
		}
		
			if (leganim.GetComponent<MegaPointCache>().time >= 70  && swipeNumber < 14) {	
				GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				swipeNumber++;
				//leganim.GetComponent<MegaPointCache>().time = 11f;
				guiChange();
		}
			if (leganim.GetComponent<MegaPointCache>().time >= 75  && swipeNumber < 15) {	
				GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				swipeNumber++;
				//leganim.GetComponent<MegaPointCache>().time = 11f;
				guiChange();
		}
			if (leganim.GetComponent<MegaPointCache>().time >= 80  && swipeNumber < 16) {	
				GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				swipeNumber++;
				//leganim.GetComponent<MegaPointCache>().time = 11f;
				guiChange();
		}
			if (leganim.GetComponent<MegaPointCache>().time >= 85  && swipeNumber < 17) {	
				GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				swipeNumber++;
				//leganim.GetComponent<MegaPointCache>().time = 11f;
				guiChange();
		}
			if (leganim.GetComponent<MegaPointCache>().time >= 90  && swipeNumber < 18) {	
				GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				swipeNumber++;
				//leganim.GetComponent<MegaPointCache>().time = 11f;
				guiChange();
		}
			if (leganim.GetComponent<MegaPointCache>().time >= 95  && swipeNumber < 19) {	
				GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				swipeNumber++;
				//leganim.GetComponent<MegaPointCache>().time = 11f;
				guiChange();
		}
			if (leganim.GetComponent<MegaPointCache>().time >= 100  && swipeNumber < 20) {	
				GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				swipeNumber++;
				//leganim.GetComponent<MegaPointCache>().time = 11f;
				guiChange();
		}
			if (leganim.GetComponent<MegaPointCache>().time >= 105  && swipeNumber < 21) {	
				GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				swipeNumber++;
				//leganim.GetComponent<MegaPointCache>().time = 11f;
				guiChange();
		}
			if (leganim.GetComponent<MegaPointCache>().time >= 110  && swipeNumber < 22) {	
				GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				swipeNumber++;
				//leganim.GetComponent<MegaPointCache>().time = 11f;
				guiChange();
		}
			if (leganim.GetComponent<MegaPointCache>().time >= 115  && swipeNumber < 23) {	
				GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				swipeNumber++;
				//leganim.GetComponent<MegaPointCache>().time = 11f;
				guiChange();
		}
			if (leganim.GetComponent<MegaPointCache>().time >= 120  && swipeNumber < 24) {	
				GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				swipeNumber++;
				//leganim.GetComponent<MegaPointCache>().time = 11f;
				guiChange();
		}
			if (leganim.GetComponent<MegaPointCache>().time >= 125  && swipeNumber < 25) {	
				GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				swipeNumber++;
				//leganim.GetComponent<MegaPointCache>().time = 11f;
				guiChange();
		}*/
		
	}
	public void booleanChange(){
		
		boolean = true;
	}
	
	
	public void guiChange(){
		
		leganim.GetComponent<MenuButton>().step++;
			steps.guiTexture.texture = pracstep[leganim.GetComponent<MenuButton>().step];
	
			}
		
	public void control(){
		leganim.GetComponent<LegZoom2>().control = 1;
	}
}
