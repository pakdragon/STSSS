using UnityEngine;
using System.Collections;

public class AnimationTest : MonoBehaviour {
	
	public GameObject leganim;
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
	
		/*theCache = leganim.GetComponent<MegaPointCache>();
		theObject = GetComponent<MegaModifyObject>();
		StartCoroutine(TimeStop());*/
	}
	
	
	
		
		
		
	// Update is called once per frame
	void Update () {
		
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
		if (Input.GetMouseButtonDown(0)){
			GetComponent<MegaModifyObject>().enabled = true;
		
		}
			
			if (leganim.GetComponent<MegaPointCache>().time > 2 && leganim.GetComponent<MegaPointCache>().time < 2.1f) {	
				GetComponent<MegaModifyObject>().enabled = false;
				leganim.GetComponent<MegaPointCache>().time = 2.1f;
			}
			
		
		
			if ( Input.GetMouseButtonDown(0)){
			GetComponent<MegaModifyObject>().enabled = true;
		}
			
			if (leganim.GetComponent<MegaPointCache>().time >= 5  && leganim.GetComponent<MegaPointCache>().time < 5.1f) {	
				GetComponent<MegaModifyObject>().enabled = false;
				leganim.GetComponent<MegaPointCache>().time = 5.1f;
			}
		
	
			if ( Input.GetMouseButtonDown(0)){
			GetComponent<MegaModifyObject>().enabled = true;
		}
			
			if (leganim.GetComponent<MegaPointCache>().time >= 8  && leganim.GetComponent<MegaPointCache>().time < 8.1f) {	
				GetComponent<MegaModifyObject>().enabled = false;
			}
		
		
		
		
		
	}
}
