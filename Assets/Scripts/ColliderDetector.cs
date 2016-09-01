using UnityEngine;
using System.Collections;

public class ColliderDetector : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision colDAta)
    {        
        print("Collision");
    }
}
