using UnityEngine;
using System.Collections;

public class Push : MonoBehaviour {
	
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnCollisionStay(Collision col)
	{
		if(col.gameObject.tag == "Ball" && Input.GetKey(KeyCode.P))
		{
			Vector3 direction = col.transform.position - transform.position;
			direction.Normalize();
			col.gameObject.rigidbody.AddForce(direction*500);
			col.gameObject.rigidbody.AddForce(new Vector3(0,200,0));
		}

	}
}
