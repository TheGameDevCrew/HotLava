using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	public float MoveSpeed = 0.2f;

	public float objectbalance = 0;
	public float BalanceRate = 1.0f;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(BalanceRate > 1){BalanceRate = 1f;}
		if(BalanceRate < 0){BalanceRate = 0f;}
		BalanceRate -= objectbalance;
		if(Input.GetKey(KeyCode.Q))
		{
			BalanceRate += 0.1f;
		}
		if(Input.GetKey(KeyCode.E))
		{
			BalanceRate += 0.1f;
		}

		if(Input.GetKey(KeyCode.W))
		{
			transform.Translate(0,0,MoveSpeed*BalanceRate);
		}
		if(Input.GetKey(KeyCode.S))
		{
			transform.Translate(0,0,-MoveSpeed*BalanceRate);
		}
		if(Input.GetKey(KeyCode.A))
		{
			transform.Translate(-MoveSpeed*BalanceRate,0,0);
		}
		if(Input.GetKey(KeyCode.D))
		{
			transform.Translate(MoveSpeed*BalanceRate,0,0);
		}

		if(Jump.canJump == false)
		{
			MoveSpeed = 0.15f;
		}
		else
		{
			MoveSpeed = 0.3f;
		}
	}
	/*
	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "Floor")
		{
			Destroy(gameObject);
		}
	}
	//*/
	void OnCollisionStay(Collision colB)
	{
		if (colB.gameObject.tag == "SmallTable" && transform.position.y > colB.gameObject.transform.renderer.bounds.size.y)
		{
			float playersX = transform.position.x;
			float playersZ = transform.position.z;
			Vector3 playerVect =  new Vector3(playersX,0,playersZ);
			playerVect.Normalize();
			float objX = colB.gameObject.transform.position.x;
			float objZ = colB.gameObject.transform.position.z;
			Vector3 objVect = new Vector3(objX,0,objZ);
			objVect.Normalize();
			objectbalance = Vector3.Distance(objVect, playerVect);

			//objectbalance = Vector3.Distance(colB.gameObject.transform.renderer.bounds.center, transform.renderer.bounds.center);
		}
	}

	void OnCollisionExit(Collision col)
	{
		if (col.gameObject.tag == "SmallTable")
		{
			objectbalance = 0;
			BalanceRate = 1;
		}
	}
}
