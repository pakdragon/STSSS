using UnityEngine;
using System.Collections;

public class AnimationTest : MonoBehaviour {
	
	public GameObject leganim;
	public GameObject lateral;
	public GameObject mesh;
	public GameObject latmark;
	public GameObject latfascia;
	public GameObject scalpel;
	public GameObject scalpel2;
	public GameObject scissors;
	public GameObject scissors2;
	public GameObject marker;
	public GameObject fascia;
	public GameObject muscle;
	public GameObject medcamera;
	public bool boolean = false;
	public Texture2D[] pracstep = new Texture2D[25];
	public string [] myStrings;
	public GUIText simtext;
	//public int Gumbo;
	public GUITexture steps;
	public GameObject legcamera;
	public float x;
	public float y;
	public float z;
	
	public int swipeNumber;
	public int currIndex;
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
		latmark.GetComponent<MegaModifyObject>().enabled = false;
		latfascia.GetComponent<MegaModifyObject>().enabled = false;
		lateral.GetComponent<MegaModifyObject>().enabled = false;
		scalpel.SetActive(false);
		scalpel2.SetActive(false);
		scissors.SetActive(false);
		scissors2.SetActive(false);
		lateral.SetActive(false);
	
		/*theCache = leganim.GetComponent<MegaPointCache>();
		theObject = GetComponent<MegaModifyObject>();
		StartCoroutine(TimeStop());*/
	}
	
	
	
		
		
		
	// Update is called once per frame
	void Update () {
		
		scalpel.SetActive(false);
		
		myStrings= new string[]{"Medial Incision", "Mark Incision", "Expose and free Muscles","Lateral Incision", "Mark Incision", "Incise skin & \nSubcutaneous Tissue", "Perform 'H-cut'; \nwatch for peroneal nerve", "Fasciotomy Complete"};
		
		Vector3 StartPos = new Vector3(5.84703f, 8.825114f, -2.739926f);
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
		
		Vector3 Scalp2Start = new Vector3(6.340768f, 8.893035f, -3.136076f);
		Vector3 Scalp2End = new Vector3(6.502913f, 8.748761f, -2.099815f);
		
		Vector3 NewScalp2Start = new Vector3(6.457504f, 8.857244f, -2.839539f);
		Vector3 NewScalp2End = new Vector3(6.435395f, 8.774544f, -2.855611f);
		
		Vector3 Sciss2Start = new Vector3(6.647907f, 8.799544f, -2.890492f);
		Vector3 Sciss2End = new Vector3(6.726021f, 8.687196f, -2.302183f);
		
		Vector3 Sciss2NewEnd = new Vector3(6.628624f, 8.830592f, -3.084681f);
		
		Vector3 NewSciss2Start = new Vector3(6.585983f, 8.721992f, -2.933432f);
		Vector3 NewSciss2End = new Vector3(6.624071f, 8.675237f, -2.396934f);
		
		Vector3 FinalSciss2End = new Vector3(6.587159f, 8.744503f, -2.894232f);
			
		//Quaternion Scalp2 = new Quaternion(-15.03967f, -90.39825f, 170.1163f, -180f);
		//Quaternion Scalp2Finish = new Quaternion(-15.03967f, -90.39825f, 87.95862f, 180f);
		
		if (steps.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)  && (leganim.GetComponent<MenuButton>().step == 0 /*|| leganim.GetComponent<MenuButton>().step == 1*/ )){
			control ();
			guiChange();
			
			if (simtext.enabled == true){
				TextChange();
			}
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
			if (simtext.enabled == true){
				TextChange();
			}
			
			}
			
		
		
		if (boolean == true && swipeNumber == 2){
			leganim.GetComponent<MegaModifyObject>().enabled = true;
			leganim.GetComponent<MegaPointCache>().time = 4f;
			marker.GetComponent<MegaModifyObject>().enabled = true;
			//scalpel.SetActive(true);
			scalpel.transform.position = StartPos2;
			y = 0;
			x = 0;
			swipeNumber++;
		}
		
		
		if (leganim.GetComponent<AnimationTest>().swipeNumber == 3 ){
			
			scalpel.transform.position = StartPos2;
			scalpel.SetActive(true);
			//print ("I'm back again");
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
			if (simtext.enabled == true){
				TextChange();
			}
			
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
		
		if (fascia.GetComponent<MegaPointCache>().time > 6.3f && fascia.GetComponent<MegaPointCache>().time < 7f){
			
			scissors.transform.position = Sciss;
			scissors.transform.rotation = First;
			scissors.SetActive(true);
			z = 0;
		}
		
		
		if (fascia.GetComponent<MegaPointCache>().time > 6.1f && fascia.GetComponent<MegaPointCache>().time < 7.6f){
			
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
			if (simtext.enabled == true){
				TextChange();
			}
			
			}
		
	/*	if (boolean == true && swipeNumber == 6){
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
		*/
		
			
		if (steps.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0) && swipeNumber == 6){ //leganim.GetComponent<MenuButton>().step == 5){
			medcamera.camera.enabled = false;
			medcamera.SetActive (false);
			legcamera.SetActive( true);
			legcamera.camera.enabled = true;
			lateral.SetActive(true);
			mesh.SetActive(false);
			legcamera.transform.position = Vector3.Lerp (StartPos, EndPos, x);
			swipeNumber++;
			if (x < 1){
				x = x + .08f;
			}
			guiChange();
			
			if (simtext.enabled == true){
				TextChange();
			}
		}
	
		
			if (boolean == true && swipeNumber == 7){
			latmark.GetComponent<MegaModifyObject>().enabled = true;
			swipeNumber++;
		}
		
		if (latmark.GetComponent<MegaPointCache>().time > 1.5f && swipeNumber == 8) {	
				control ();
				latmark.GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				swipeNumber++;
				
				guiChange();
			if (simtext.enabled == true){
				TextChange();
			}
			
		}
		
		if (boolean == true && swipeNumber == 9){
			lateral.GetComponent<MegaModifyObject>().enabled = true;
			lateral.GetComponent<MegaPointCache>().time = 1f;
			latmark.GetComponent<MegaModifyObject>().enabled = true;
			scalpel2.SetActive(true);
			scalpel2.transform.position = Scalp2Start;
			scalpel2.transform.eulerAngles = new Vector3(-15.03967f, -90.39825f, 170.1163f);
			y = 0;
			x = 0;
			swipeNumber++;
		}
		
		if (leganim.GetComponent<AnimationTest>().swipeNumber == 10 ){
			
			scalpel2.transform.position = Scalp2Start;
			scalpel2.SetActive(true);
			//print ("I'm back again");
			scalpel2.transform.position = Vector3.Lerp (Scalp2Start, Scalp2End, y);
				if (y < 1){
				y = y + .05f;
			}
		}
		
		
		if (latmark.GetComponent<MegaPointCache>().time > 4f  && swipeNumber == 10 ) {
			control ();	
			latmark.GetComponent<MegaModifyObject>().enabled = false;
			}
		
		if (lateral.GetComponent<MegaPointCache>().time > 5f  && swipeNumber == 10) {	
			control ();	
			lateral.GetComponent<MegaModifyObject>().enabled = false;
			scalpel2.SetActive(false);
				
				boolean = false;
				swipeNumber ++;
				guiChange();
			if (simtext.enabled == true){
				TextChange();
			}
			
			}
		
		if (boolean == true && swipeNumber == 11){
			latfascia.GetComponent<MegaModifyObject>().enabled = true;
			latfascia.GetComponent<MegaPointCache>().time = 4.8f;
			scalpel2.transform.position = NewScalp2End;
			scalpel2.transform.eulerAngles = new Vector3(-15.03967f, -90.39825f, 87.95862f);
			scalpel2.SetActive(true);
			y = 0;
			swipeNumber ++;
		
		}
		
		
		if (latfascia.GetComponent<MegaPointCache>().time == 4f && swipeNumber == 12){
			scalpel2.transform.position = Vector3.Lerp (NewScalp2Start, NewScalp2End,x);
				if (x < 1){
				x = x + .05f;
			}
		}
		
		
		if (latfascia.GetComponent<MegaPointCache>().time > 5f){
			
			scalpel2.SetActive(false);
		}
		
		if (latfascia.GetComponent<MegaPointCache>().time > 5f && latfascia.GetComponent<MegaPointCache>().time < 5.5f){
			
			scissors2.transform.position = Sciss2Start;
			scissors2.transform.eulerAngles = new Vector3(-71.37486f, -728.6573f, -498.7535f) ;
			scissors2.SetActive(true);
			z = 0;
		}
		
		
		if (latfascia.GetComponent<MegaPointCache>().time > 5f && latfascia.GetComponent<MegaPointCache>().time < 6f){
			
			scissors2.transform.position = Vector3.Lerp (Sciss2Start, Sciss2End, z);
				if (z < 1){
				z = z + .3f;
			}
			
		}
		
		if (latfascia.GetComponent<MegaPointCache>().time > 6.4f && latfascia.GetComponent<MegaPointCache>().time < 7.4f){
			
			scissors2.transform.eulerAngles = new Vector3(78.16133f, -1039.875f, -502.5256f) ; 
			scissors2.transform.position = Vector3.Lerp (Sciss2Start, Sciss2NewEnd, y);
			x = 0;
			z = 0;
				if (y < 1){
				y = y + .3f;
			}
			
		}
		
		if (latfascia.GetComponent<MegaPointCache>().time > 7.4f && latfascia.GetComponent<MegaPointCache>().time < 8.3f){
			scissors2.transform.position = NewSciss2Start;
			scissors2.transform.eulerAngles = new Vector3(-71.37486f, -728.6573f, -498.7535f);
			scissors2.transform.position = Vector3.Lerp (NewSciss2Start, NewSciss2End, x);
				if (x < 1){
				x = x + .3f;
			}
			
		}
		
		if (latfascia.GetComponent<MegaPointCache>().time > 8.3f && latfascia.GetComponent<MegaPointCache>().time < 9.1f){
			
			scissors2.transform.position = NewSciss2Start;
			scissors2.transform.eulerAngles = new Vector3(78.16133f, -1039.875f, -502.5256f);
			scissors2.transform.position = Vector3.Lerp(NewSciss2Start, FinalSciss2End, z);
			swipeNumber++;
			
				if (z < 1){
				z = z + .3f;
			}
				
				
		}	
			
			
			
			
		
		
			if (latfascia.GetComponent<MegaPointCache>().time > 9.1 ) {	
			control ();	
			latfascia.GetComponent<MegaModifyObject>().enabled = false;
				boolean = false;
				scissors2.SetActive(false);
				//swipeNumber++;
				//leganim.GetComponent<MegaPointCache>().time = 11f;
				//guiChange();
				scissors2.SetActive(false);
			if (simtext.enabled == true){
				//TextChange();
			}
			
			}
		
		
		
	
		
	}
	public void booleanChange(){
		
		boolean = true;
	}
	
	
	public void guiChange(){
		
		leganim.GetComponent<MenuButton>().step++;
			steps.guiTexture.texture = pracstep[leganim.GetComponent<MenuButton>().step];
	
			}
	
		public void TextChange(){
			
			currIndex++;
			simtext.text = myStrings[currIndex];
		}
		
	public void control(){
		leganim.GetComponent<LegZoom2>().control = 1;
	}
}
