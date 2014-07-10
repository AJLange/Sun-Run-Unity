using UnityEngine;
using System.Collections;

public class HillScript : MonoBehaviour {

	public Vector2 speed = new Vector2(5, 0);
	private Vector2 movement;
	
	// Use this for initialization
	void Start () {
		
	}
	
	void Update (){
		movement = new Vector2(
			speed.x * 1,
			0);
		
	}
	
	
	// Update is called once per frame
	void FixedUpdate () {
		rigidbody2D.velocity = movement;
		
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			Debug.Break ();
			return;
		}
		
		if (other.tag == "Wall") {
						Destroy (gameObject);
				} else
						return;
	}
}

