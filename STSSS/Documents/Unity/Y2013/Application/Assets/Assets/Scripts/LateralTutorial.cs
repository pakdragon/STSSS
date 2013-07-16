/* Save the Soldier Surgical Simulation
 * 
 * Year/Summer at the Edge 2012-2013
 * 
 * Dr. Rob Williams
 * 
 * Tyler Maschino
 * 
 *-----------------------------------------*/

using UnityEngine;
using System.Collections;

public class LateralTutorial: MonoBehaviour {
//public GameObject arrows;
//public GameObject layers;
public GameObject MainCamera;
public GUITexture Forward;
public GUITexture Backward;
public GUITexture bar1;
public GUITexture bar2;
public GUITexture titleBar;
public GUITexture medialTitleBar;
public GUITexture background;
//public GUITexture Home;
/*public GameObject Num1;
public GameObject Num2;
public GameObject Num3;
public GameObject Num4;
public GameObject Num5;
public GameObject Num6;
public GameObject Num7;
public GameObject Num8;*/

//public GameObject Step1;
//public GameObject Step2;
//public GameObject Step3;
//public GameObject Step4;
public GameObject Step5;
public GameObject Step6;		
public GameObject Step7;
public GameObject Step8;
	
private GUITexture picture1;
private GUITexture picture2;
private GUITexture picture3;

private bool show1;
private bool show2;
private bool show3;
public bool resize1;
public bool resize2;
public bool resize3;
private float x1;
private float x2;
private float x3;
private float y1;
private float y2;
private float y3;
private float y1Change;
private float y2Change;
private float y3Change;
private float x1Change;
private float x2Change;
private float x3Change;
private float changeX1;
private float changeY1;
private float changeX2;
private float changeY2;
private float changeX3;
private float changeY3;	
	
	
private float height1 = 192;
private float height2 = 192;
private float height3 = 192;
private float width1 = 192;
private float width2 = 192;
private float width3 = 192;

public GUITexture caption13;
public GUITexture caption14;
public GUITexture caption15;
public GUITexture caption16;
public GUITexture caption17;
public GUITexture caption18;
public GUITexture caption19;
public GUITexture caption20;
public GUITexture caption21;
public GUITexture caption22;
public GUITexture caption23;
public GUITexture caption24;

public GameObject Cap13;
public GameObject Cap14;
public GameObject Cap15;
public GameObject Cap16;
public GameObject Cap17;
public GameObject Cap18;
public GameObject Cap19;
public GameObject Cap20;
public GameObject Cap21;
public GameObject Cap22;
public GameObject Cap23;
public GameObject Cap24;
	
	
public float a;
		

private GameObject[] pictures = new GameObject[12];
	
public GameObject 
	pic13,pic14,pic15,
	pic16,pic17,pic18,pic19,pic20,pic21,
	pic22,pic23,pic24;

private GUITexture[] images = new GUITexture[12];
	
public GUITexture
	image13,image14,image15,image16,image17,image18,
	image19,image20,image21,image22,image23,image24;
	
public int lateralCount = 0;
public Vector3[] positions = new Vector3[1];
public Vector3[] rotations = new Vector3[4];
	
	void Start() {
		
		
		screenResize();
		
		
		background.guiTexture.color = new Color(255,255,255, 0f);
		
		//transparency
		//0 means transparent, 1 means opaque
		a = 0f;
		
		background.transform.localPosition = new Vector3(0,0,4);
		
		//minimize();
		resize1 = false;
		resize2 = false;
		resize3 = false;
		
		x1 = image13.pixelInset.x;
		x2 = image14.pixelInset.x;
		x3 = image15.pixelInset.x;
		y1 = image13.pixelInset.y;
		y2 = image14.pixelInset.y;
		y3 = image15.pixelInset.y;
		
		images[0] = image13;
		images[1] = image14;
		images[2] = image15;
		images[3] = image16;
		images[4] = image17;
		images[5] = image18;
		images[6] = image19;
		images[7] = image20;
		images[8] = image21;
		images[9] = image22;
		images[10] = image23;
		images[11] = image24;
		
		pictures[0] = pic13;
		pictures[1] = pic14;
		pictures[2] = pic15;
		pictures[3] = pic16;
		pictures[4] = pic17;
		pictures[5] = pic18;
		pictures[6] = pic19;
		pictures[7] = pic20;
		pictures[8] = pic21;
		pictures[9] = pic22;
		pictures[10] = pic23;
		pictures[11] = pic24;
		
		rotations[0] = new Vector3(0,305,0);
		rotations[1] = new Vector3(0,35,0);
		rotations[2] = new Vector3(0,125,0);
		rotations[3] = new Vector3(0,215,0);
		
		positions[0] = new Vector3(-20,2,70);
		
	}
	
	// Update is called once per frame
	void Update () {
		if(lateralCount == 0) {
			resize(image13,image14,image15,Cap13,Cap14,Cap15,image16.pixelInset.x, image16.pixelInset.y, image17.pixelInset.x, image17.pixelInset.y, image18.pixelInset.x, image18.pixelInset.y);
		}
		if(lateralCount ==1) {
			resize(image16,image17,image18,Cap16,Cap17,Cap18,image13.pixelInset.x, image13.pixelInset.y, image14.pixelInset.x, image14.pixelInset.y, image15.pixelInset.x, image15.pixelInset.y);
		}
		if(lateralCount == 2) {
			resize(image19,image20,image21,Cap19,Cap20,Cap21,image13.pixelInset.x, image13.pixelInset.y, image14.pixelInset.x, image14.pixelInset.y, image15.pixelInset.x, image15.pixelInset.y);
		}
		if(lateralCount ==3) {
			resize(image22,image23,image24,Cap22,Cap23,Cap24,image13.pixelInset.x, image13.pixelInset.y, image14.pixelInset.x, image14.pixelInset.y, image15.pixelInset.x, image15.pixelInset.y);
		}
		
		if (Forward.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)) {
			//audio.Play();
			//Forward.guiTexture.texture = forwardDown;
			//minimize();
			
			forward();
			
			resize1 = false;
			resize2 = false;
			resize3 = false;
				
		}
		
		/*if (Input.GetMouseButtonUp(0)) {
			Forward.guiTexture.texture = forwardUp;
			Backward.guiTexture.texture = backwardUp;
			}
			*/
		
		if (Backward.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)) {
			//audio.Play();
			//Backward.guiTexture.texture = backwardDown;
			//minimize();
			
			backward();
			
			resize1 = false;
			resize2 = false;
			resize3 = false;
			
		}
		
	}
	
	void forward() {		
		if (lateralCount == 0) {
			iTween.RotateTo(gameObject, iTween.Hash("rotation", rotations[1], "time", 2.5));
			lateralCount++;
		
			//Num5.SetActiveRecursively(false);
			//Num6.SetActiveRecursively(true);
		
			Step5.SetActiveRecursively(false);
			Step6.SetActiveRecursively(true);
		
			pic13.SetActiveRecursively(false);
			pic14.SetActiveRecursively(false);
			pic15.SetActiveRecursively(false);
		
			pic16.SetActiveRecursively(true);
			pic17.SetActiveRecursively(true);
			pic18.SetActiveRecursively(true);
			
		}
		else if (lateralCount == 1) {
			iTween.RotateTo(gameObject, iTween.Hash("rotation", rotations[2], "time", 2.5));
			lateralCount++;
		
			//Num6.SetActiveRecursively(false);
			//Num7.SetActiveRecursively(true);
		
			Step6.SetActiveRecursively(false);
			Step7.SetActiveRecursively(true);
		
			pic16.SetActiveRecursively(false);
			pic17.SetActiveRecursively(false);
			pic18.SetActiveRecursively(false);
		
			pic19.SetActiveRecursively(true);
			pic20.SetActiveRecursively(true);
			pic21.SetActiveRecursively(true);
			
		}
		else if (lateralCount == 2) {
			iTween.RotateTo(gameObject, iTween.Hash("rotation", rotations[3], "time", 2.5));
			lateralCount++;
		
			//Num7.SetActiveRecursively(false);
			//Num8.SetActiveRecursively(true);
		
			Step7.SetActiveRecursively(false);
			Step8.SetActiveRecursively(true);
		
			pic19.SetActiveRecursively(false);
			pic20.SetActiveRecursively(false);
			pic21.SetActiveRecursively(false);
			
			pic22.SetActiveRecursively(true);
			pic23.SetActiveRecursively(true);
			pic24.SetActiveRecursively(true);
			
		}
		else if (lateralCount == 3) {
			iTween.RotateTo(gameObject, iTween.Hash("rotation", rotations[0], "time", 2.5));
			lateralCount=0;
			//Num8.SetActiveRecursively(false);
			//Num5.SetActiveRecursively(true);
			Step8.SetActiveRecursively(false);
			Step5.SetActiveRecursively(true);
		
			pic22.SetActiveRecursively(false);
			pic23.SetActiveRecursively(false);
			pic24.SetActiveRecursively(false);
			
			pic13.SetActiveRecursively(true);
			pic14.SetActiveRecursively(true);
			pic15.SetActiveRecursively(true);
			
		}
	}
	
	void backward() {
		
		if (lateralCount == 1) {
			iTween.RotateTo(gameObject, iTween.Hash("rotation", rotations[0], "time", 2.5));
			lateralCount--;
			//Num6.SetActiveRecursively(false);
			//Num5.SetActiveRecursively(true);
			Step6.SetActiveRecursively(false);
			Step5.SetActiveRecursively(true);
		
			pic13.SetActiveRecursively(true);
			pic14.SetActiveRecursively(true);
			pic15.SetActiveRecursively(true);
			
			pic16.SetActiveRecursively(false);
			pic17.SetActiveRecursively(false);
			pic18.SetActiveRecursively(false);
		}
		else if (lateralCount == 2) {
			iTween.RotateTo(gameObject, iTween.Hash("rotation", rotations[1], "time", 2.5));
			lateralCount--;
			//Num7.SetActiveRecursively(false);
			//Num6.SetActiveRecursively(true);
			Step7.SetActiveRecursively(false);
			Step6.SetActiveRecursively(true);
		
			pic16.SetActiveRecursively(true);
			pic17.SetActiveRecursively(true);
			pic18.SetActiveRecursively(true);
			
			pic19.SetActiveRecursively(false);
			pic20.SetActiveRecursively(false);
			pic21.SetActiveRecursively(false);
		}
		else if (lateralCount == 3) {
			iTween.RotateTo(gameObject, iTween.Hash("rotation", rotations[2], "time", 2.5));
			lateralCount--;
			//Num8.SetActiveRecursively(false);
			//Num7.SetActiveRecursively(true);
			Step8.SetActiveRecursively(false);
			Step7.SetActiveRecursively(true);
			
			pic19.SetActiveRecursively(true);
			pic20.SetActiveRecursively(true);
			pic21.SetActiveRecursively(true);
			
			pic22.SetActiveRecursively(false);
			pic23.SetActiveRecursively(false);
			pic24.SetActiveRecursively(false);
		}
		else if (lateralCount == 0) {
			iTween.RotateTo(gameObject, iTween.Hash("rotation", rotations[3], "time", 2.5));
			lateralCount=3;
			//Num5.SetActiveRecursively(false);
			//Num8.SetActiveRecursively(true);
			Step5.SetActiveRecursively(false);
			Step8.SetActiveRecursively(true);
		
			pic22.SetActiveRecursively(true);
			pic23.SetActiveRecursively(true);
			pic24.SetActiveRecursively(true);
			
			pic13.SetActiveRecursively(false);
			pic14.SetActiveRecursively(false);
			pic15.SetActiveRecursively(false);
		}
	}
	
	void resize(GUITexture picture1, GUITexture picture2, GUITexture picture3, GameObject cap1, GameObject cap2, GameObject cap3, float originalX1, float originalY1, float originalX2, float originalY2, float originalX3, float originalY3) {
		
		width1 = picture1.pixelInset.width;
		width2 = picture2.pixelInset.width;
		width3 = picture3.pixelInset.width;
		height1 = picture1.pixelInset.height;
		height2 = picture2.pixelInset.height;
		height3 = picture3.pixelInset.height;
		x1 = picture1.pixelInset.x;
		x2 = picture2.pixelInset.x;
		x3 = picture3.pixelInset.x;
		y1 = picture1.pixelInset.y;
		y2 = picture2.pixelInset.y;
		y3 = picture3.pixelInset.y;
		changeX1 = (float) (Screen.width/4f-originalX1)/16;
		changeY1 = (float) (Screen.height/4f-originalY1)/16;
		changeX2 = (float) (Screen.width/4f-originalX2)/16;
		changeY2 = (float) (Screen.height/4f-originalY2)/16;
		changeX3 = (float) (Screen.width/4f-originalX3)/16;
		changeY3 = (float) (Screen.height/4f-originalY3)/16;
		
		
		
		
		
		
		if (picture1.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)) {
			audio.Play();
			picture1.transform.position = new Vector3(0, 0, 5);
			picture2.transform.position = new Vector3(0, 0, 2);
			picture3.transform.position = new Vector3(0, 0, 2);
			resize1 = !resize1;
			resize2 = false;
			resize3 = false;
			cap1.SetActiveRecursively(false);
			cap2.SetActiveRecursively(false);
			cap3.SetActiveRecursively(false);
			
		}
		
		if (picture2.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)) {
			audio.Play();
			picture2.transform.position = new Vector3(0, 0, 5);
			picture1.transform.position = new Vector3(0, 0, 2);
			picture3.transform.position = new Vector3(0, 0, 2);
			resize2 = !resize2;
			resize1 = false;
			resize3 = false;
			cap1.SetActiveRecursively(false);
			cap2.SetActiveRecursively(false);
			cap3.SetActiveRecursively(false);
		}
		
		if (picture3.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)) {
			audio.Play();
			picture3.transform.position = new Vector3(0, 0, 5);
			picture2.transform.position = new Vector3(0, 0, 2);
			picture1.transform.position = new Vector3(0, 0, 2);
			resize3 = !resize3;
			resize1 = false;
			resize2 = false;
			cap1.SetActiveRecursively(false);
			cap2.SetActiveRecursively(false);
			cap3.SetActiveRecursively(false);
		}
		
	    if(resize1 == true) {
	    	
			if (width1<(Screen.width/2f) || height1<(Screen.height/2f)) {
				width1+=(.046875f*(Screen.width/2f));
				height1+=(.046875f*(Screen.height/2f));
				x1+=changeX1;
				y1+=changeY1;
				a+=.03125f;
				picture1.pixelInset = new Rect(x1, y1, width1, height1);
				background.guiTexture.color = new Color(255,255,255,a);
	 			
				
			}
			
			else{
				cap1.SetActive(true);
			}
			
			
	    }
	    
	    else {
	    	if (width1>((1f/8f)*Screen.width) || height1>((1f/8f)*Screen.width)) {
				width1-=(.046875f*(Screen.width/2f));
				height1-=(.046875f*(Screen.height/2f));	
				x1-=changeX1;
				y1-=changeY1;
				a-=.03125f;
	 			picture1.pixelInset = new Rect(x1, y1, width1, height1);
				background.guiTexture.color = new Color(255,255,255,a);
			}
			
			if (width1==((1f/8f)*Screen.width) || height1==((1f/8f)*Screen.width)) {
				cap1.SetActive(false);
				picture1.transform.localPosition = new Vector3(0,0,0);
				
			}
			
		
			
	    }
		
	    
	    if(resize2 == true) {
	    	
		if (width2<(Screen.width/2f) || height2<(Screen.height/2f)) {
				width2+=(.046875f*(Screen.width/2f));
				height2+=(.046875f*(Screen.height/2f));
				x2+=changeX2;
				y2+=changeY2;
				a+=.03125f;
	 			picture2.pixelInset = new Rect(x2, y2, width2, height2);
				background.guiTexture.color = new Color(255,255,255,a);
				
	
				
				
			}
			
			else {
				cap2.SetActive(true);
	    }
		}
	    else {
	    	if (width2>((1f/8f)*Screen.width) || height2>((1f/8f)*Screen.width)) {
				width2-=(.046875f*(Screen.width/2f));
				height2-=(.046875f*(Screen.height/2f));	
				x2-=changeX2;
				y2-=changeY2;
				a-=.03125f;
	 			picture2.pixelInset = new Rect(x2, y2, width2, height2);
				background.guiTexture.color = new Color(255,255,255,a);
			}
			
			if (width2==((1f/8f)*Screen.width) || height2==((1f/8f)*Screen.width)) {
				cap2.SetActiveRecursively(false);
				picture2.transform.localPosition = new Vector3(0,0,0);
				
			}
			
			
			
	    }
	    
	    if(resize3 == true) {
	    	
		if (width3<(Screen.width/2f) || height3<(Screen.height/2f)) {
				width3+=(.046875f*(Screen.width/2f));
				height3+=(.046875f*(Screen.height/2f));
				x3+=changeX3;
				y3+=changeY3;
				a+=.03125f;
	 			picture3.pixelInset = new Rect(x3, y3, width3, height3);
				background.guiTexture.color = new Color(255,255,255,a);
	
				
				
			}
			
			else{
				cap3.SetActive(true);
	    }
		}
	    else {
	    	if (width3>((1f/8f)*Screen.width) || height3>((1f/8f)*Screen.width)) {
				width3-=(.046875f*(Screen.width/2f));
				height3-=(.046875f*(Screen.height/2f));	
				x3-=changeX3;
				y3-=changeY3;
				a-=.03125f;
	 			picture3.pixelInset = new Rect(x3, y3, width3, height3);
				background.guiTexture.color = new Color(255,255,255,a);
			}
			
			if (width3==((1f/8f)*Screen.width) || height3==((1f/8f)*Screen.width)) {
				cap3.SetActiveRecursively(false);
				picture3.transform.localPosition = new Vector3(0,0,0);
				
			}
			
			
			
	    }
	}
	
	/*public void minimize() {
		image13.pixelInset = new Rect(64, 192, 192, 192);
		image14.pixelInset = new Rect(320, 192, 192, 192);
		image15.pixelInset = new Rect(576, 192, 192, 192);
		image16.pixelInset = new Rect(64, 192, 192, 192);
		image17.pixelInset = new Rect(320, 192, 192, 192);
		image18.pixelInset = new Rect(576, 192, 192, 192);
		image19.pixelInset = new Rect(64, 192, 192, 192);
		image20.pixelInset = new Rect(320, 192, 192, 192);
		image21.pixelInset = new Rect(576, 192, 192, 192);
		image22.pixelInset = new Rect(64, 192, 192, 192);
		image23.pixelInset = new Rect(320, 192, 192, 192);
		image24.pixelInset = new Rect(576, 192, 192, 192);
		Cap13.SetActiveRecursively(false);
		Cap14.SetActiveRecursively(false);
		Cap15.SetActiveRecursively(false);
		Cap16.SetActiveRecursively(false);
		Cap17.SetActiveRecursively(false);
		Cap18.SetActiveRecursively(false);
		Cap19.SetActiveRecursively(false);
		Cap20.SetActiveRecursively(false);
		Cap21.SetActiveRecursively(false);
		Cap22.SetActiveRecursively(false);
		Cap23.SetActiveRecursively(false);
		Cap24.SetActiveRecursively(false);
		
	}*/
	
	void screenResize() {
		
		//Resize banners
		titleBar.pixelInset = new Rect(0,0,Screen.width, (1f/12f)*Screen.height);
		medialTitleBar.pixelInset = new Rect(0,Screen.height-(1f/12f)*Screen.height,Screen.width, (1f/12f)*Screen.height);
		bar1.pixelInset = new Rect(0,(1f/12f)*Screen.height,Screen.width,(1f/192f)*Screen.height);
		bar2.pixelInset = new Rect(0,Screen.height-(1f/12f)*Screen.height-(1f/192f)*Screen.height,Screen.width,(1f/192f)*Screen.height);
		//arrows.guiTexture.pixelInset = new Rect((400f/512f)*Screen.width, (100f/512f)*Screen.width, 2*((1f/12f)*Screen.height-2f*(5f/512f)*Screen.width),(1f/12f)*Screen.height-2f*(5f/512f)*Screen.width);
		Forward.guiTexture.pixelInset = new Rect((80f/512f)*Screen.width, (100f/512f)*Screen.width, 3*((1f/12f)*Screen.height-2f*(5f/512f)*Screen.width),(2f/12f)*Screen.height-2f*(5f/512f)*Screen.width);
		Backward.guiTexture.pixelInset = new Rect((50f/512f)*Screen.width, (100f/512f)*Screen.width, 3*((1f/12f)*Screen.height-2f*(5f/512f)*Screen.width),(2f/12f)*Screen.height-2f*(5f/512f)*Screen.width);
		
		//Resize gradient (background used for transparency/opacity)
		background.pixelInset = new Rect(0,(17f/192f)*Screen.height,Screen.width,(158f/192f)*Screen.height);
		
		image13.pixelInset = new Rect((20f/512f)*Screen.width, (30f/512f)*Screen.width, (12.5f/100f)*Screen.width, (12.5f/100f)*Screen.height);
		image14.pixelInset = new Rect((90f/512f)*Screen.width, (30f/512f)*Screen.width, (12.5f/100f)*Screen.width, (12.5f/100f)*Screen.height);
		image15.pixelInset = new Rect((160f/512f)*Screen.width, (30f/512f)*Screen.width, (12.5f/100f)*Screen.width, (12.5f/100f)*Screen.height);
		image16.pixelInset = new Rect((20f/512f)*Screen.width, (30f/512f)*Screen.width, (12.5f/100f)*Screen.width, (12.5f/100f)*Screen.height);
		image17.pixelInset = new Rect((90f/512f)*Screen.width, (30f/512f)*Screen.width, (12.5f/100f)*Screen.width, (12.5f/100f)*Screen.height);
		image18.pixelInset = new Rect((160f/512f)*Screen.width, (30f/512f)*Screen.width, (12.5f/100f)*Screen.width, (12.5f/100f)*Screen.height);
		image19.pixelInset = new Rect((20f/512f)*Screen.width, (30f/512f)*Screen.width, (12.5f/100f)*Screen.width, (12.5f/100f)*Screen.height);
		image20.pixelInset = new Rect((90f/512f)*Screen.width, (30f/512f)*Screen.width, (12.5f/100f)*Screen.width, (12.5f/100f)*Screen.height);
		image21.pixelInset = new Rect((160f/512f)*Screen.width, (30f/512f)*Screen.width, (12.5f/100f)*Screen.width, (12.5f/100f)*Screen.height);
		image22.pixelInset = new Rect((20f/512f)*Screen.width, (30f/512f)*Screen.width, (12.5f/100f)*Screen.width, (12.5f/100f)*Screen.height);
		image23.pixelInset = new Rect((90f/512f)*Screen.width, (30f/512f)*Screen.width, (12.5f/100f)*Screen.width, (12.5f/100f)*Screen.height);
		image24.pixelInset = new Rect((160f/512f)*Screen.width, (30f/512f)*Screen.width, (12.5f/100f)*Screen.width, (12.5f/100f)*Screen.height);
		
		
		Cap13.guiTexture.pixelInset = new Rect((8f/32f)*Screen.width, (2f/16f)*Screen.height, (7f/16f)*Screen.width,(1f/24f)*Screen.height);
		Cap14.guiTexture.pixelInset = new Rect((10f/32f)*Screen.width, (2f/16f)*Screen.height, (7f/16f)*Screen.width,(1f/24f)*Screen.height);
		Cap15.guiTexture.pixelInset =new Rect((10f/32f)*Screen.width, (2f/16f)*Screen.height, (7f/16f)*Screen.width,(1f/24f)*Screen.height);
		Cap16.guiTexture.pixelInset = new Rect((10f/32f)*Screen.width, (2f/16f)*Screen.height, (7f/16f)*Screen.width,(1f/24f)*Screen.height);
		Cap17.guiTexture.pixelInset = new Rect((10f/32f)*Screen.width, (2f/16f)*Screen.height, (7f/16f)*Screen.width,(1f/24f)*Screen.height);
		Cap18.guiTexture.pixelInset = new Rect((10f/32f)*Screen.width, (2f/16f)*Screen.height, (7f/16f)*Screen.width,(1f/24f)*Screen.height);
		Cap19.guiTexture.pixelInset = new Rect((10f/32f)*Screen.width, (2f/16f)*Screen.height, (7f/16f)*Screen.width,(1f/24f)*Screen.height);
		Cap20.guiTexture.pixelInset = new Rect((10f/32f)*Screen.width, (2f/16f)*Screen.height, (7f/16f)*Screen.width,(1f/24f)*Screen.height);
		Cap21.guiTexture.pixelInset = new Rect((10f/32f)*Screen.width, (2f/16f)*Screen.height, (7f/16f)*Screen.width,(1f/24f)*Screen.height);
		Cap22.guiTexture.pixelInset = new Rect((10f/32f)*Screen.width, (2f/16f)*Screen.height, (7f/16f)*Screen.width,(1f/24f)*Screen.height);
		Cap23.guiTexture.pixelInset = new Rect((10f/32f)*Screen.width, (2f/16f)*Screen.height, (7f/16f)*Screen.width,(1f/24f)*Screen.height);
		Cap24.guiTexture.pixelInset = new Rect((10f/32f)*Screen.width, (2f/16f)*Screen.height, (7f/16f)*Screen.width,(1f/24f)*Screen.height);
		
		
		
		
		
		
		Step5.guiTexture.pixelInset = new Rect((250f/512f)*Screen.width, (40f/512f)*Screen.width, 15*(1f/12f)*Screen.height,(9f/12f)*Screen.height-2f*(5f/512f)*Screen.width);
		Step6.guiTexture.pixelInset = new Rect((250f/512f)*Screen.width, (40f/512f)*Screen.width, 15*(1f/12f)*Screen.height,(9f/12f)*Screen.height-2f*(5f/512f)*Screen.width);
		Step7.guiTexture.pixelInset =new Rect((250f/512f)*Screen.width, (40f/512f)*Screen.width, 15*(1f/12f)*Screen.height,(9f/12f)*Screen.height-2f*(5f/512f)*Screen.width);
		Step8.guiTexture.pixelInset = new Rect((250f/512f)*Screen.width, (40f/512f)*Screen.width, 15*(1f/12f)*Screen.height,(9f/12f)*Screen.height-2f*(5f/512f)*Screen.width);
		
		
	}
	
		void OnGUI () {
		
		//Display button to take user back to menu
		if (GUI.Button(new Rect((5f/512f)*Screen.width,(5f/512f)*Screen.width,2*((1f/12f)*Screen.height-2f*(5f/512f)*Screen.width),(1f/12f)*Screen.height-2f*(5f/512f)*Screen.width),"Menu")) {
			Application.LoadLevel(3);	
		}
	}
}