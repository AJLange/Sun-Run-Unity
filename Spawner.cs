using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawner : MonoBehaviour {

	public GameObject[] enemyPool;
	public float maxdelay = 3.0f;
	public float mindelay = 2.5f;
	public bool active = true;
	private Vector2 direction = new Vector2(1,1);
	private IList<GameObject> targets;
	private gizmo parentGizmo;

	// Use this for initialization
	void Start () {

		parentGizmo = gameObject.GetComponent<gizmo> ();
		targets = parentGizmo.targets;
		StartCoroutine (EnemyGenerator ());
	
	}

	IEnumerator EnemyGenerator()
	{
				if (active) {
						var newTransform = transform;
						yield return new WaitForSeconds (Random.Range (mindelay, maxdelay));

						if (targets.Count > 0) { 
								var spawnTarget = targets [Random.Range (0, targets.Count)];
								newTransform = spawnTarget.transform;
								direction = spawnTarget.transform.localScale;
						}

						GameObject clone = Instantiate (enemyPool[Random.Range(0, enemyPool.Length)], newTransform.position, Quaternion.identity) as GameObject;
						clone.transform.localScale = direction;
						StartCoroutine (EnemyGenerator ());
				}
		}

	
	// Update is called once per frame
	void Update () {
	
	}
}
