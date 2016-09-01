using UnityEngine;
using System.Collections;

public class Forward : MonoBehaviour {

    public GameManagerBowl manager;
    private Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.anyKeyDown) {
            rigidbody.AddForce(new Vector3(Random.Range(-500, 500), Random.Range(-500, 500), 1000));
            manager.start = true;
        }
	
	}
}
