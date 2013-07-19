using UnityEngine;
using System.Collections;

public class Phase2Text : MonoBehaviour {

public GameObject Player;
public GameObject Text;



	// Use this for initialization
	void Start () {
	}

	
	// Update is called once per frame
	void Update () {
		
	if (((Text.transform.position.x)-(Player.transform.position.x)) < 27f)
		
		{	Text.SetActive(true);
		
		}
		else{
			Text.SetActive(false);
		}
	}
}