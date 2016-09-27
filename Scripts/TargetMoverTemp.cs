using UnityEngine;
using System.Collections;

public class TargetMoverTemp : MonoBehaviour {

	public float spinSpeed = 180.0f;
	public float motionMagnitude = 0.1f;

	public enum motionDirection { Spin, Horizontal, Vectical };

	public motionDirection motionState = motionDirection.Horizontal;
	// Update is called once per frame
	void Update () {
		switch (motionState) {
		case motionDirection.Spin: 
			gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);
			break;
		case motionDirection.Horizontal:
			gameObject.transform.Translate (Vector3.right * Mathf.Cos (Time.timeSinceLevelLoad) * motionMagnitude);
			break;
		case motionDirection.Vectical:
			gameObject.transform.Translate (Vector3.up * Mathf.Cos (Time.timeSinceLevelLoad) * motionMagnitude);
			break;
		}
	
	}
}
