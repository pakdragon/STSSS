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

public class MedialTutorial: MonoBehaviour {
//public GameObject arrows;
public GameObject MainCamera;
public GUITexture Forward;
public GUITexture Backward;
public GUITexture bar1;
public GUITexture bar2;
public GUITexture titleBar;
public GUITexture medialTitleBar;
public GUITexture background;

/*
public GameObject Num1;
public GameObject Num2;
public GameObject Num3;
public GameObject Num4;
public GameObject Num5;
public GameObject Num6;
public GameObject Num7;
public GameObject Num8;
*/	 

public GameObject Step1;
public GameObject Step2;
public GameObject Step3;
public GameObject Step4;
	
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
	
public GUITexture caption1;
public GUITexture caption2;
public GUITexture caption3;
public GUITexture caption4;
public GUITexture caption5;
public GUITexture caption6;
public GUITexture caption7;
public GUITexture caption8;
public GUITexture caption9;
public GUITexture caption10;
public GUITexture caption11;
public GUITexture caption12;
	

public GameObject Cap1;
public GameObject Cap2;
public GameObject Cap3;
public GameObject Cap4;
public GameObject Cap5;
public GameObject Cap6;
public GameObject Cap7;
public GameObject Cap8;
public GameObject Cap9;
public GameObject Cap10;
public GameObject Cap11;
public GameObject Cap12;
	
public float a;
		

private GameObject[] pictures = new GameObject[12];
	
public GameObject 
	pic1,pic2,pic3,pic4,pic5,pic6,pic7,pic8,
	pic9,pic10,pic11,pic12;

private GUITexture[] images = new GUITexture[12];
	
public GUITexture
	image1,image2,image3,image4,image5,image6,
	image7,image8,image9,image10,image11,image12;
	
public int lateralCount = 0;
public int medialCount = 0;
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
		
		x1 = image1.pixelInset.x;
		x2 = image2.pixelInset.x;
		x3 = image3.pixelInset.x;
		y1 = image1.pixelInset.y;
		y2 = image2.pixelInset.y;
		y3 = image3.pixelInset.y;
		
		images[0] = image1;
		images[1] = image2;
		images[2] = image3;
		images[3] = image4;
		images[4] = image5;
		images[5] = image6;
		images[6] = image7;
		images[7] = image8;
		images[8] = image9;
		images[9] = image10;
		images[10] = image11;
		images[11] = image12;
		
		pictures[0] = pic1;
		pictures[1] = pic2;
		pictures[2] = pic3;
		pictures[3] = pic4;
		pictures[4] = pic5;
		pictures[5] = pic6;
		pictures[6] = pic7;
		pictures[7] = pic8;
		pictures[8] = pic9;
		pictures[9] = pic10;
		pictures[10] = pic11;
		
		rotations[0] = new Vector3(0,305,0);
		rotations[1] = new Vector3(0,35,0);
		rotations[2] = new Vector3(0,125,0);
		rotations[3] = new Vector3(0,215,0);
		
		positions[0] = new Vector3(20,2,70);
		
	}
	
	// Update is called once per frame
	void Update () {
		if(medialCount == 0) {
			resize(image1,image2,image3,Cap1,Cap2,Cap3,image4.pixelInset.x, image4.pixelInset.y, image5.pixelInset.x, image5.pixelInset.y, image6.pixelInset.x, image6.pixelInset.y);
		}
		if(medialCount ==1) {
			resize(image4,image5,image6,Cap4,Cap5,Cap6,image1.pixelInset.x, image1.pixelInset.y, image2.pixelInset.x, image2.pixelInset.y, image3.pixelInset.x, image3.pixelInset.y);
		}
		if(medialCount == 2) {
			resize(image7,image8,image9,Cap7,Cap8,Cap9,image1.pixelInset.x, image1.pixelInset.y, image2.pixelInset.x, image2.pixelInset.y, image3.pixelInset.x, image3.pixelInset.y);
		}
		if(medialCount ==3) {
			resize(image10,image11,image12,Cap10,Cap11,Cap12,image1.pixelInset.x, image1.pixelInset.y, image2.pixelInset.x, image2.pixelInset.y, image3.pixelInset.x, image3.pixelInset.y);
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
			
		if (medialCount == 0) {
			iTween.RotateTo(gameObject, iTween.Hash("rotation", rotations[1], "time", 2.5));
			medialCount++;
			
			//Num1.SetActiveRecursively(false);
			//Num2.SetActiveRecursively(true);
			
			Step1.SetActiveRecursively(false);
			Step2.SetActiveRecursively(true);
			
			pic1.SetActiveRecursively(false);
			pic2.SetActiveRecursively(false);
			pic3.SetActiveRecursively(false);
			
			pic4.SetActiveRecursively(true);
			pic5.SetActiveRecursively(true);
			pic6.SetActiveRecursively(true);
			
			
		}
		else if (medialCount == 1) {
			iTween.RotateTo(gameObject, iTween.Hash("rotation", rotations[2], "time", 2.5));
			medialCount++;
		
			//Num2.SetActiveRecursively(false);
			//Num3.SetActiveRecursively(true);
		
			Step2.SetActiveRecursively(false);
			Step3.SetActiveRecursively(true);
		
			pic4.SetActiveRecursively(false);
			pic5.SetActiveRecursively(false);
			pic6.SetActiveRecursively(false);
		
			pic7.SetActiveRecursively(true);
			pic8.SetActiveRecursively(true);
			pic9.SetActiveRecursively(true);
			
			
		}
		else if (medialCount == 2) {
			iTween.RotateTo(gameObject, iTween.Hash("rotation", rotations[3], "time", 2.5));
			medialCount++;
		
			//Num3.SetActiveRecursively(false);
			//Num4.SetActiveRecursively(true);
		
			Step3.SetActiveRecursively(false);
			Step4.SetActiveRecursively(true);
		
			pic7.SetActiveRecursively(false);
			pic8.SetActiveRecursively(false);
			pic9.SetActiveRecursively(false);
		
			pic10.SetActiveRecursively(true);
			pic11.SetActiveRecursively(true);
			pic12.SetActiveRecursively(true);
			
		}
		else if (medialCount == 3) {
			iTween.RotateTo(gameObject, iTween.Hash("rotation", rotations[0], "time", 2.5));
			medialCount=0;
		
			//Num4.SetActiveRecursively(false);
			//Num1.SetActiveRecursively(true);
		
			Step4.SetActiveRecursively(false);
			Step1.SetActiveRecursively(true);
		
			pic10.SetActiveRecursively(false);
			pic11.SetActiveRecursively(false);
			pic12.SetActiveRecursively(false);
		
			pic1.SetActiveRecursively(true);
			pic2.SetActiveRecursively(true);
			pic3.SetActiveRecursively(true);
			
		}
	}
	
	void backward() {
		if (medialCount == 1) {
			iTween.RotateTo(gameObject, iTween.Hash("rotation", rotations[0], "time", 2.5));
			medialCount--;
			//Num2.SetActiveRecursively(false);
			//Num1.SetActiveRecursively(true);
			Step2.SetActiveRecursively(false);
			Step1.SetActiveRecursively(true);
		
			pic1.SetActiveRecursively(true);
			pic2.SetActiveRecursively(true);
			pic3.SetActiveRecursively(true);
			
			pic4.SetActiveRecursively(false);
			pic5.SetActiveRecursively(false);
			pic6.SetActiveRecursively(false);
		}
		else if (medialCount == 2) {
			iTween.RotateTo(gameObject, iTween.Hash("rotation", rotations[1], "time", 2.5));
			medialCount--;
			//Num3.SetActiveRecursively(false);
			//Num2.SetActiveRecursively(true);
			Step3.SetActiveRecursively(false);
			Step2.SetActiveRecursively(true);
		
			pic4.SetActiveRecursively(true);
			pic5.SetActiveRecursively(true);
			pic6.SetActiveRecursively(true);
			
			pic7.SetActiveRecursively(false);
			pic8.SetActiveRecursively(false);
			pic9.SetActiveRecursively(false);
		}
		else if (medialCount == 3) {
			iTween.RotateTo(gameObject, iTween.Hash("rotation", rotations[2], "time", 2.5));
			medialCount--;
			//Num4.SetActiveRecursively(false);
			//Num3.SetActiveRecursively(true);
			Step4.SetActiveRecursively(false);
			Step3.SetActiveRecursively(true);
		
			pic7.SetActiveRecursively(true);
			pic8.SetActiveRecursively(true);
			pic9.SetActiveRecursively(true);
			
			pic10.SetActiveRecursively(false);
			pic11.SetActiveRecursively(false);
			pic12.SetActiveRecursively(false);
		}
		else if (medialCount == 0) {
			iTween.RotateTo(gameObject, iTween.Hash("rotation", rotations[3], "time", 2.5));
			medialCount=3;
			//Num1.SetActiveRecursively(false);
			//Num4.SetActiveRecursively(true);
			Step1.SetActiveRecursively(false);
			Step4.SetActiveRecursively(true);
		
			pic10.SetActiveRecursively(true);
			pic11.SetActiveRecursively(true);
			pic12.SetActiveRecursively(true);
			
			pic1.SetActiveRecursively(false);
			pic2.SetActiveRecursively(false);
			pic3.SetActiveRecursively(false);
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
			//audio.Play();
			picture1.transform.position = new Vector3(0, 0, 5);
			picture2.transform.position = new Vector3(0, 0, 2);
			picture3.transform.position = new Vector3(picture3.transform.position.x, picture3.transform.position.y, 2);
			resize1 = !resize1;
			resize2 = false;
			resize3 = false;
			cap1.SetActiveRecursively(false);
			cap2.SetActiveRecursively(false);
			cap3.SetActiveRecursively(false);
			
		}
		
		if (picture2.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)) {
			//audio.Play();
			picture2.transform.position = new Vector3(0, 0, 5);
			picture1.transform.position = new Vector3(picture1.transform.position.x, picture1.transform.position.y, 2);
			picture3.transform.position = new Vector3(picture3.transform.position.x, picture3.transform.position.y, 2);
			resize2 = !resize2;
			resize1 = false;
			resize3 = false;
			cap1.SetActiveRecursively(false);
			cap2.SetActiveRecursively(false);
			cap3.SetActiveRecursively(false);
		}
		
		if (picture3.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)) {
			//audio.Play();
			picture3.transform.position = new Vector3(0, 0, 5);
			picture2.transform.position = new Vector3(picture2.transform.position.x, picture2.transform.position.y, 2);
			picture1.transform.position = new Vector3(picture1.transform.position.x, picture1.transform.position.y, 2);
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
			
			/*if (width1==(Screen.width/2f) || height1==(Screen.height/2f)) {
				cap1.SetActive(true);
			}*/
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
		image1.pixelInset = new Rect(64, 192, 192, 192);
		image2.pixelInset = new Rect(320, 192, 192, 192);
		image3.pixelInset = new Rect(576, 192, 192, 192);
		image4.pixelInset = new Rect(64, 192, 192, 192);
		image5.pixelInset = new Rect(320, 192, 192, 192);
		image6.pixelInset = new Rect(576, 192, 192, 192);
		image7.pixelInset = new Rect(64, 192, 192, 192);
		image8.pixelInset = new Rect(320, 192, 192, 192);
		image9.pixelInset = new Rect(576, 192, 192, 192);
		image10.pixelInset = new Rect(64, 192, 192, 192);
		image11.pixelInset = new Rect(320, 192, 192, 192);
		image12.pixelInset = new Rect(576, 192, 192, 192);
		Cap1.SetActiveRecursively(false);
		Cap2.SetActiveRecursively(false);
		Cap3.SetActiveRecursively(false);
		Cap4.SetActiveRecursively(false);
		Cap5.SetActiveRecursively(false);
		Cap6.SetActiveRecursively(false);
		Cap7.SetActiveRecursively(false);
		Cap8.SetActiveRecursively(false);
		Cap9.SetActiveRecursively(false);
		Cap10.SetActiveRecursively(false);
		Cap11.SetActiveRecursively(false);
		Cap12.SetActiveRecursively(false);
	}
	*/
	
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
		
		image1.pixelInset = new Rect((20f/512f)*Screen.width, (30f/512f)*Screen.width, (12.5f/100f)*Screen.width, (12.5f/100f)*Screen.height);
		image2.pixelInset = new Rect((90f/512f)*Screen.width, (30f/512f)*Screen.width, (12.5f/100f)*Screen.width, (12.5f/100f)*Screen.height);
		image3.pixelInset = new Rect((160f/512f)*Screen.width, (30f/512f)*Screen.width, (12.5f/100f)*Screen.width, (12.5f/100f)*Screen.height);
		image4.pixelInset = new Rect((20f/512f)*Screen.width, (30f/512f)*Screen.width, (12.5f/100f)*Screen.width, (12.5f/100f)*Screen.height);
		image5.pixelInset = new Rect((90f/512f)*Screen.width, (30f/512f)*Screen.width, (12.5f/100f)*Screen.width, (12.5f/100f)*Screen.height);
		image6.pixelInset = new Rect((160f/512f)*Screen.width, (30f/512f)*Screen.width, (12.5f/100f)*Screen.width, (12.5f/100f)*Screen.height);
		image7.pixelInset = new Rect((20f/512f)*Screen.width, (30f/512f)*Screen.width, (12.5f/100f)*Screen.width, (12.5f/100f)*Screen.height);
		image8.pixelInset = new Rect((90f/512f)*Screen.width, (30f/512f)*Screen.width, (12.5f/100f)*Screen.width, (12.5f/100f)*Screen.height);
		image9.pixelInset = new Rect((160f/512f)*Screen.width, (30f/512f)*Screen.width, (12.5f/100f)*Screen.width, (12.5f/100f)*Screen.height);
		image10.pixelInset = new Rect((20f/512f)*Screen.width, (30f/512f)*Screen.width, (12.5f/100f)*Screen.width, (12.5f/100f)*Screen.height);
		image11.pixelInset = new Rect((90f/512f)*Screen.width, (30f/512f)*Screen.width, (12.5f/100f)*Screen.width, (12.5f/100f)*Screen.height);
		image12.pixelInset = new Rect((160f/512f)*Screen.width, (30f/512f)*Screen.width, (12.5f/100f)*Screen.width, (12.5f/100f)*Screen.height);
		
		
		Cap1.guiTexture.pixelInset = new Rect((8f/32f)*Screen.width, (2f/16f)*Screen.height, (7f/16f)*Screen.width,(1f/24f)*Screen.height);
		Cap2.guiTexture.pixelInset = new Rect((10f/32f)*Screen.width, (2f/16f)*Screen.height, (7f/16f)*Screen.width,(1f/24f)*Screen.height);
		Cap3.guiTexture.pixelInset =new Rect((10f/32f)*Screen.width, (2f/16f)*Screen.height, (7f/16f)*Screen.width,(1f/24f)*Screen.height);
		Cap4.guiTexture.pixelInset = new Rect((10f/32f)*Screen.width, (2f/16f)*Screen.height, (7f/16f)*Screen.width,(1f/24f)*Screen.height);
		Cap5.guiTexture.pixelInset = new Rect((10f/32f)*Screen.width, (2f/16f)*Screen.height, (7f/16f)*Screen.width,(1f/24f)*Screen.height);
		Cap6.guiTexture.pixelInset = new Rect((10f/32f)*Screen.width, (2f/16f)*Screen.height, (7f/16f)*Screen.width,(1f/24f)*Screen.height);
		Cap7.guiTexture.pixelInset = new Rect((10f/32f)*Screen.width, (2f/16f)*Screen.height, (7f/16f)*Screen.width,(1f/24f)*Screen.height);
		Cap8.guiTexture.pixelInset = new Rect((10f/32f)*Screen.width, (2f/16f)*Screen.height, (7f/16f)*Screen.width,(1f/24f)*Screen.height);
		Cap9.guiTexture.pixelInset = new Rect((10f/32f)*Screen.width, (2f/16f)*Screen.height, (7f/16f)*Screen.width,(1f/24f)*Screen.height);
		Cap10.guiTexture.pixelInset = new Rect((10f/32f)*Screen.width, (2f/16f)*Screen.height, (7f/16f)*Screen.width,(1f/24f)*Screen.height);
		Cap11.guiTexture.pixelInset = new Rect((10f/32f)*Screen.width, (2f/16f)*Screen.height, (7f/16f)*Screen.width,(1f/24f)*Screen.height);
		Cap12.guiTexture.pixelInset = new Rect((10f/32f)*Screen.width, (2f/16f)*Screen.height, (7f/16f)*Screen.width,(1f/24f)*Screen.height);
		
		
		
		
		
		
		Step1.guiTexture.pixelInset = new Rect((180f/512f)*Screen.width, (40f/512f)*Screen.width, 15*(1f/12f)*Screen.height,(9f/12f)*Screen.height-2f*(5f/512f)*Screen.width);
		Step2.guiTexture.pixelInset = new Rect((180f/512f)*Screen.width, (40f/512f)*Screen.width, 15*(1f/12f)*Screen.height,(9f/12f)*Screen.height-2f*(5f/512f)*Screen.width);
		Step3.guiTexture.pixelInset =new Rect((220f/512f)*Screen.width, (40f/512f)*Screen.width, 15*(1f/12f)*Screen.height,(9f/12f)*Screen.height-2f*(5f/512f)*Screen.width);
		Step4.guiTexture.pixelInset = new Rect((180f/512f)*Screen.width, (40f/512f)*Screen.width, 15*(1f/12f)*Screen.height,(9f/12f)*Screen.height-2f*(5f/512f)*Screen.width);
		
		
	}
	
		void OnGUI () {
		
		//Display button to take user back to menu
		if (GUI.Button(new Rect((5f/512f)*Screen.width,(5f/512f)*Screen.width,2*((2f/12f)*Screen.height-1f*(5f/512f)*Screen.width),(1f/12f)*Screen.height-2f*(5f/512f)*Screen.width),"Menu")) {
			Application.LoadLevel(3);	
		}
	}
	
	
}