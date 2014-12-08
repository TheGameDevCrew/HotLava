using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {

	public float speed;

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, rigidbody.velocity.y/speed, moveVertical);
		rigidbody.velocity = movement * speed;
	}
}
