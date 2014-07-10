using UnityEngine;
using System.Collections;

public class BGRotate : MonoBehaviour {

	public float BGRotSpeed = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate()
	{
		// rotate this
		transform.Rotate (Vector3.up, BGRotSpeed * Time.deltaTime);
	}
}
