using UnityEngine;
using System.Collections;

public class target_move : MonoBehaviour {
	Vector3 originalpos;
	float jumpheight = 6f;
	public float moveSpeed;
	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if (Input.GetKey (KeyCode.UpArrow)) 
		{
			transform.Translate(0,0,moveSpeed*Time.deltaTime);
			transform.rotation = Quaternion.LookRotation(Vector3.forward, Vector3.up);//face forward
			
		}
		if (Input.GetKey (KeyCode.DownArrow)) 
		{
			transform.Translate(0,0,moveSpeed*Time.deltaTime);
			transform.rotation = Quaternion.LookRotation(Vector3.back, Vector3.up); //face back
		}
		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			transform.Translate(0,0,moveSpeed*Time.deltaTime);
			transform.rotation = Quaternion.LookRotation(Vector3.left, Vector3.up); //face left
		}
		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			transform.Translate (0, 0, moveSpeed*Time.deltaTime);
			transform.rotation = Quaternion.LookRotation(Vector3.right, Vector3.up); //face right
		} 
		if (Input.GetKey (KeyCode.J))
		{
			originalpos = transform.localPosition;  //takes the objects orginal position
			transform.localPosition = new Vector3( originalpos.x, jumpheight, originalpos.z ); //
		}
	}
}