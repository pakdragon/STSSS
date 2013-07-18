using UnityEngine;
using System.Collections;

public class AnimationTest : MonoBehaviour {
	
	public GameObject leganim;
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
		
		swipeNumber = 0;
		//Gumbo = leganim.GetComponent<LegZoom2>().step;
		legcamera.transform.position = new Vector3(4.54f, 9.434f, -3.932f);
		marker.GetComponent<MegaModifyObject>().enabled = false;
		muscle.GetComponent<MegaModifyObject>().enabled = false;
		fascia.GetComponent<MegaModifyObject>().enabled = false;
	
		/*theCache = leganim.GetComponent<MegaPointCache>();
		theObject = GetComponent<MegaModifyObject>();
		StartCoroutine(TimeStop());*/
	}
	
	
	
		
		
		
	// Update is called once per frame
	void Update () {
		
		Vector3 StartPos = new Vector3(4.54f, 9.434f, -3.932f);
		Vector3 EndPos = new Vector3 (6.1f, 9.1f, -4.017f);
		//legcamera.transform.position = new Vector3(4.54f, 9.434f, -3.932f);
		/*if (Input.GetMouseButtonDown(0)) {
			theObject.enabled = true;
		}
		
	}
	
	IEnumerator TimeStop()
	{
		while (true)
		{
			yield return new WaitForEndOfFrame();
			
			if (theCache.time>= intervalTime)
			{theObject.enabled = false;
			}
		}
	}
}*/
		
		if (steps.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)  && (leganim.GetComponent<MenuButton>().step == 0 /*|| leganim.GetComponent<MenuButton>().step == 1*/ )){
			control ();
			guiChange();
		}
		
		
		if (boolean == true && swipeNumber == 0){
			marker.GetComponent<MegaModifyObject>().enabled = true;
			
		
		}
			
			if (marker.GetComponent<MegaPointCache>().time > 4f && swipeNumber == 0) {	
				control ();
				marker.GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				//leganim.GetComponent<MegaPointCache>().time = 2.1f;
				swipeNumber ++;
				
				guiChange();
			
			}
			
		
		
		if (boolean == true && swipeNumber == 1){
			leganim.GetComponent<MegaModifyObject>().enabled = true;
			leganim.GetComponent<MegaPointCache>().time = 4f;
			marker.GetComponent<MegaModifyObject>().enabled = true;
			swipeNumber++;
		}
			
		
		if (marker.GetComponent<MegaPointCache>().time > 9f  && swipeNumber == 2 ) {
			control ();	
			marker.GetComponent<MegaModifyObject>().enabled = false;
			
			
		}
			
			
			
			if (leganim.GetComponent<MegaPointCache>().time > 9f  && swipeNumber == 2) {	
			control ();	
			leganim.GetComponent<MegaModifyObject>().enabled = false;
				
				boolean = false;
				swipeNumber ++;
				guiChange();
			
			}
		
	if (boolean == true && swipeNumber == 3){
			fascia.GetComponent<MegaModifyObject>().enabled = true;
			fascia.GetComponent<MegaPointCache>().time = 5f;
			swipeNumber ++;
		
		}
	
			
			if (fascia.GetComponent<MegaPointCache>().time > 9  && swipeNumber == 4) {	
			control ();	
			fascia.GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				swipeNumber++;
				//leganim.GetComponent<MegaPointCache>().time = 11f;
				guiChange();
			
			}
		
		if (boolean == true && swipeNumber == 5){
			muscle.GetComponent<MegaModifyObject>().enabled = true;
			muscle.GetComponent<MegaPointCache>().time = 5f;
			
			swipeNumber++;
		
		}
		
				if (muscle.GetComponent<MegaPointCache>().time > 9  && swipeNumber == 6) {	
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
