using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	public bool release = false;
	public float chargeJump = 400.0f;
	public static bool canJump = true;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(release)
		{
			rigidbody.AddForce(new Vector3(0,chargeJump,0));
			release = false;
			chargeJump = 400.0f;

		}
		if(Input.GetKey(KeyCode.Space) && canJump)
		{
			chargeJump += 10.0f;
			if(chargeJump > 800)
			{
				chargeJump = 800;
			}
		}
		if(Input.GetKeyUp(KeyCode.Space) && canJump)
		{
			release = true;
		}
	}
	void OnCollisionStay(Collision col)
	{
		if(col.gameObject.tag == "Floor" || col.gameObject.tag == "Couch" || col.gameObject.tag == "Pillow")
		{
			canJump = true;
		}

	}
	void OnCollisionExit(Collision col)
	{
		if(col.gameObject.tag == "Floor" || col.gameObject.tag == "Couch")
		{
			canJump = false;
		}
	}


}
