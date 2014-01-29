using UnityEngine;
using System.Collections;

public class Camera_Behavior : MonoBehaviour {

	public Transform interpolateTo;
	public float interpolateSpeed = 1.0f;
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp (transform.position, interpolateTo.position, 
		                                   Time.deltaTime * interpolateSpeed);
		transform.rotation = Quaternion.Lerp(transform.rotation, interpolateTo.rotation, 
		                                   Time.deltaTime * interpolateSpeed);
	}
}