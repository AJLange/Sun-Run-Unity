using UnityEngine;
using System.Collections;

public class Runner : MonoBehaviour {

	public static float distanceTraveled;
	public Vector2 speed = new Vector2(50, 50);
	private Vector2 movement;
	float mouseY = 0; 


	
	// Update is called once per frame
	void Update () {


		//transform.Translate(5f * Time.deltaTime, aggression/25, 0f);
		distanceTraveled = transform.localPosition.x;


		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");

		if (Input.GetMouseButtonDown (0)) 
		{  
			mouseY = 90 * ((Input.mousePosition.y - Screen.height / 2) / (Screen.height / 2));  

		} 
		else 
		{  
			mouseY = 0; 
		} 


	
		// Movement per direction
		//mouse or keyboard

		if (mouseY > 0)
		{
			movement = new Vector2(speed.x * inputX, speed.y);
		}
		else if (mouseY < 0)
		{
			movement = new Vector2(speed.x * inputX, -speed.y);
		}
		else
		{
		movement = new Vector2(speed.x * inputX, speed.y * inputY);
		}

	}

	void FixedUpdate()
	{
		// Move the game object
		rigidbody2D.velocity = movement;
	}

}
