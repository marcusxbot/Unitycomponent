using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class okok : MonoBehaviour
 {
public SpriteRenderer rend;
public 
public Color color;
	// Use this for initialization
	void Start () 
	{
	
		//rend.color = new color(1,0.25f,0.33f);

		//transform.position.x = new Vector(-5f,transform.position.y);

		// transform.Rotate(0,0,15f);
		// transform.Translate(-5f,0,0);
	}
	
	// Update is called once per frame
	void Update ()
	 {
 if (Input.GetKey(KeyCode.UpArrow)){
		 transform.Translate(-3f * Time.deltaTime, 0, 0, Space.Self); }

 if (Input.GetKey(KeyCode.DownArrow))
 {
		 transform.Translate(-3f * Time.deltaTime, 0, 0, Space.Self); 
		 
		 TrailRenderer.endcolor = new Color(1,0,1);
 }


if (Input.GetKey(KeyCode.LeftArrow)) {
		transform.Rotate(0,0,50f * Time.deltaTime);}
if (Input.GetKey(KeyCode.RightArrow)) {
		transform.Rotate(0,0,-50f * Time.deltaTime); }

	}
}
