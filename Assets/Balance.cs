using UnityEngine;
using System.Collections;

public class Balance : MonoBehaviour {

	public float objectbalance = 0;
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
		if (col.gameObject.tag == "SmallTable")
		{
			objectbalance = Vector3.Distance(col.gameObject.transform.renderer.bounds.center, transform.renderer.bounds.center);
		}
	}
}
