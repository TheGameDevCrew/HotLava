using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {

	public float playerleft = 0;
	public float playertop = 0;
	public float playerwidth = 100;
	public float playerheight = 50;

	public Texture player;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnGUI()
	{
		GUI.DrawTexture(new Rect(playerleft,playertop,playerwidth,playerheight),player);
	}
}
