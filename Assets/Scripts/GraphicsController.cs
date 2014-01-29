using UnityEngine;
using System.Collections;

public class GraphicsController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyUp(KeyCode.Alpha0)) {
			string statusOfVSYNC;
			if(QualitySettings.vSyncCount == 0){
				QualitySettings.vSyncCount = 1;
				statusOfVSYNC = "ON";
			}
			else{
				QualitySettings.vSyncCount = 0;
				statusOfVSYNC = "OFF";
			}
			Debug.Log("VSYNC was changed to: " + statusOfVSYNC);
		}
	}
}
