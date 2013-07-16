using UnityEngine;
using System.Collections;

public class MedCamera : MonoBehaviour {
	
	public GameObject legcamera;
	public GameObject medcamera;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector3 Start = medcamera.transform.position;
		Vector3 End = new Vector3 (7.845176f, 9.130486f, -4.382369f);
		
		
			if (legcamera.GetComponent<LegZoom2>().step >= 14){
			
			legcamera.SetActive(false);
			medcamera.SetActive(true);
			medcamera.transform.position = Vector3.Lerp(Start, End, Time.deltaTime * 2);
		
		}
		
		else{
			medcamera.SetActive(false);
			medcamera.transform.position = new Vector3(8.917773f, 9.703301f, -4.485284f);
		}
		
		
			if ((medcamera.GetComponent<LegZoom2>().steps).HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)){
			
			
			medcamera.GetComponent<LegZoom2>().step = legcamera.GetComponent<LegZoom2>().step;
		
			medcamera.GetComponent<LegZoom2>().steps.guiTexture.texture = medcamera.GetComponent<LegZoom2>().pracstep[medcamera.GetComponent<LegZoom2>().step++];
	
			}
		
		
		
		if (medcamera.GetComponent<LegZoom2>().step == 26){
			
			medcamera.GetComponent<LegZoom2>().step = -1;
			medcamera.SetActive(false);
			legcamera.SetActive(true);
			
		}
		
	
	}
}
