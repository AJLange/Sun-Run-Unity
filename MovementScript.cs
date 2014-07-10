using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour
{



	//public Vector2 speed = new Vector2(50, 50);
	//private Vector2 movement;

	public float speed = 200; 
	public float maxSpeed = 5; 
	int moving = 0; 
	float mouseY = 0; 
	
	void Update()
	{
		if (Input.GetMouseButtonDown (0)) 
		{  
			mouseY = 90 * ((Input.mousePosition.y - Screen.height / 2) / (Screen.height / 2));   
		} else 
		{  
			mouseY = 0; 
		}

		if (Input.GetKey("up") || mouseY > 0)
		{     
			moving = 1; 
		} 
		else if (Input.GetKey("down") || mouseY < 0)
		{     
			moving = -1; 
		} else 
		{     
			moving = 0; 
		} 
		// 3 - Retrieve axis information
		//float inputX = Input.GetAxis("Horizontal");
		//float inputY = Input.GetAxis("Vertical");
		
		// 4 - Movement per direction
		//movement = new Vector2(
			//speed.x * 1,
			//speed.y * inputY);

		if (moving != 0) 
		{     
			var velocityY = System.Math.Abs(rigidbody2D.velocity.y);      
			if (velocityY < .5)     
			{         
				rigidbody2D.AddForce(new Vector2(0, moving) * speed);          
				if (this.transform.localScale.y != moving)             
					this.transform.localScale = new Vector3(moving, 1, 1);     
			}      if (velocityY > maxSpeed)         
				rigidbody2D.velocity = new Vector2(maxSpeed * moving, 0); 
		}
		
	}
	
	void FixedUpdate()
	{
		// 5 - Move the game object
		//rigidbody2D.velocity = movement;
	}
}