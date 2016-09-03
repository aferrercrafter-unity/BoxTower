using UnityEngine;
using System.Collections;

public class Forward : MonoBehaviour {

    public GameManagerBowl manager;
    private Rigidbody rigidbody;

	private float force;


	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.Space)) {
			force += 50;
			print (force);
        }

		if (Input.GetKeyUp(KeyCode.Space)) {
			rigidbody.AddForce (0,0,force);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			rigidbody.AddForce (100,0,0);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			rigidbody.AddForce (-100,0,0);
		}
	
	}
}
