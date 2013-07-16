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

public class Checkmarks : MonoBehaviour {
	
	public bool[] checks = new bool[8];
	public GUITexture[] checkboxes = new GUITexture[8];
	//public Texture medialChecked;
	//public Texture lateralChecked;
	//public Texture medial;
	//public Texture lateral;
	public Texture checkedBox;
	public Texture unCheckedBox;
	// Use this for initialization
	void Start () {
		for (int i=0; i<8; i++) {
			checks[i] = false;	
		}
	}
	
	// Update is called once per frame
	void Update () {
		for (int i=0; i<4; i++) {
			if (Application.loadedLevelName=="Medial") {
				if (Camera.mainCamera.GetComponent<MedialTutorial>().medialCount == i) {
					if (checkboxes[i].HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)) {
						checks[i] = !checks[i];	
					}
					
					if (checks[i] == true) {
						checkboxes[i].guiTexture.texture = checkedBox;
					}
					
					if (checks[i] == false) {
						checkboxes[i].guiTexture.texture = unCheckedBox;
					}
				}
			}
			
			if (Application.loadedLevelName=="Lateral") {
				if (Camera.mainCamera.GetComponent<LateralTutorial>().lateralCount == i) {
					if (checkboxes[i+4].HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)) {
						checks[i+4] = !checks[i+4];	
					}
					
					if (checks[i+4] == true) {
						checkboxes[i+4].guiTexture.texture = checkedBox;
					}
					
					if (checks[i+4] == false) {
						checkboxes[i+4].guiTexture.texture = unCheckedBox;
					}
				}
			}
			
			/*if (checks[0]==true && checks[1]==true && checks[2]==true && checks[3]==true) {
				Camera.mainCamera.GetComponent<Menu>().medial.guiTexture.texture = medialChecked;
			}
			
			if (checks[4] && checks[5] && checks[6] && checks[7]) {
				Camera.mainCamera.GetComponent<Menu>().lateral.guiTexture.texture = lateralChecked;
			}
			
			if (!checks[0] || !checks[1] || !checks[2] || !checks[3]) {
				Camera.mainCamera.GetComponent<Menu>().medial.guiTexture.texture = medial;
			}
			
			if (!checks[4] || !checks[5] || !checks[6] || !checks[7]) {
				Camera.mainCamera.GetComponent<Menu>().lateral.guiTexture.texture = lateral;
			}*/
		}
		
		
	}
}
