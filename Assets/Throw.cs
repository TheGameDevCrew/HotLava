using UnityEngine;
using System.Collections;

public class Throw : MonoBehaviour {

	public bool isPickedUp = false;

	Vector3 pickUp = new Vector3 (0,0,0);

	GameObject curPillow;
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if(isPickedUp)
		{
			pickUp = transform.position;
			pickUp.y += 5;
			curPillow.transform.position = pickUp;
		}
		if(isPickedUp && Input.GetKeyUp(KeyCode.T))
		{
			isPickedUp = false;
			curPillow.rigidbody.AddForce(new Vector3(200,100,0));
		}
	}

	void OnCollisionStay(Collision col)
	{
		if(col.gameObject.tag == "Pillow" && Input.GetKeyDown(KeyCode.T))
		{
			curPillow = col.gameObject;
			isPickedUp = true;
			//curPillow.transform.position = Vector3.Lerp(curPillow.transform.position, pickUp, 10f);

		}
	}
}
