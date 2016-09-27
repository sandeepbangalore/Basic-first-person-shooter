using UnityEngine;
using System.Collections;

public class BasicController : MonoBehaviour {

	public float speed = 3.0f;
	public float gravity = 9.81f;

	private CharacterController characterController;

	void Start () {
		characterController = GetComponent<CharacterController> ();	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Horizaontal Input = " + Input.GetAxis ("Horizontal"));
		Vector3 movementZ = Input.GetAxis ("Vertical") * Vector3.forward * speed * Time.deltaTime;
		Vector3 movementX = Input.GetAxis ("Horizontal") * Vector3.right * speed * Time.deltaTime;
		Vector3 movement = transform.TransformDirection (movementZ + movementX);

		movement.y -= gravity * Time.deltaTime;

		characterController.Move (movement);
	}
}
