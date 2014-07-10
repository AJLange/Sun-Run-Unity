using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {

	public float playerScore = 0;



	// Update is called once per frame
	void Update () {

		playerScore += Time.deltaTime;
	}
	

		public static HUDScript instance;
		
		
		void OnGUI()
		{
		GUI.contentColor = Color.black;
		GUI.Label (new Rect (10, 100, 100, 30), "Score: " + (int)(playerScore * 10));
					

		}
		

}
