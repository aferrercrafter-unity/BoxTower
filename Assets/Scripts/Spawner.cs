using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject box_prefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("space")) {
			//Going up
			transform.Translate (Vector3.up);
			//Spawn box
			Instantiate(box_prefab, transform.position, Quaternion.identity);
		}

	}
}
