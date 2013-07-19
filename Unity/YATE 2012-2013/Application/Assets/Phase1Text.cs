using UnityEngine;
using System.Collections;

public class Phase1Text : MonoBehaviour 
{
public GameObject Player;
public GameObject Text;



	// Use this for initialization
	void Start () {
	}

	
	// Update is called once per frame
	void Update () {
		
	if (((Text.transform.position.x)-(Player.transform.position.x)) < 12f)
		
		{	Text.SetActive(true);
		
		}
		else{
			Text.SetActive(false);
		}
	}
}


