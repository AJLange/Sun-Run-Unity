using UnityEngine;
using System.Collections;



public class DeathScript : MonoBehaviour {
	public string scene;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
				if (other.tag == "Player") {
				EndGame();
				return;
				}

		if(other.gameObject.transform.parent)
		{
			Destroy(other.gameObject.transform.parent.gameObject);
		}
		else
		{
			Destroy (other.gameObject);
		}
	}

	void EndGame(){
		Application.LoadLevel (scene);
	}
}
