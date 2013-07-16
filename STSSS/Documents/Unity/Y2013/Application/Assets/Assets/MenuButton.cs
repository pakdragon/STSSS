using UnityEngine;
using System.Collections;

public class MenuButton : MonoBehaviour {
	
	
	public GameObject legcamera;
	public GameObject medcamera;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if (legcamera.GetComponent<LegZoom2>().menu.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)){
			
			medcamera.SetActive(false);
			legcamera.SetActive(true);
			legcamera.GetComponent<LegZoom2>().simtest.enabled = true;
			legcamera.GetComponent<LegZoom2>().simpract.enabled = true;
			legcamera.GetComponent<LegZoom2>().simtext.enabled = false;
			legcamera.GetComponent<LegZoom2>().menu.enabled = false;
			legcamera.GetComponent<LegZoom2>().steps.enabled = false;
			legcamera.GetComponent<LegZoom2>().currIndex = 0;
			legcamera.GetComponent<LegZoom2>().step = -1;
			medcamera.GetComponent<LegZoom2>().step = -1;
			legcamera.GetComponent<LegZoom2>().simtext.text = legcamera.GetComponent<LegZoom2>().myStrings[legcamera.GetComponent<LegZoom2>().currIndex];
		
			
		}
	}
}
