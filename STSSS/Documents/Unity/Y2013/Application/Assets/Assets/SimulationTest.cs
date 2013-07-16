using UnityEngine;
using System.Collections;

public class SimulationTest : MonoBehaviour {
	
	public GameObject legcamera;
	public GameObject medcamera;
	public GUIText simtext;
	public string[] myStrings = new string[]{"Lateral Incision", "Mark Incision", "Incise skin & \nSubcutaneous Tissue", "Perform 'H-cut'; \nwatch for peroneal nerve", "Lateral Incision Complete", "Medial Incision", "Mark Incision", "Expose and free Muscles", "Fasciotomy Complete"}; 
	public int currIndex;
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 Start = medcamera.transform.position;
		Vector3 End = new Vector3 (7.845176f, 9.130486f, -4.382369f);
		
			
		if (currIndex >= 5){
			
			legcamera.SetActive(false);
			medcamera.SetActive(true);
			medcamera.transform.position = Vector3.Lerp(Start, End, Time.deltaTime * 2);
		}
	
		
		
		if (simtext.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)){
			
			legcamera.GetComponent<LegZoom2>().step = -1;
			currIndex++;
			simtext.text = myStrings[currIndex];
		}
		
		
		
		
	
		else{
			medcamera.SetActive(false);
			medcamera.transform.position = new Vector3(8.917773f, 9.703301f, -4.485284f);
		}
	
	
	
	}
}
