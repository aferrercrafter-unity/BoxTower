using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject[] box_prefabs;
    public GameManager manager;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("space")) {
			//Going up
			transform.Translate (Vector3.up);
			//Spawn box
			Instantiate(box_prefabs[Random.Range(0,box_prefabs.Length)], transform.position, Quaternion.identity);
            manager.boxs++;
            Camera.main.transform.Translate(Vector3.up);
		}

	}
}
