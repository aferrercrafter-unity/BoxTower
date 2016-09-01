using UnityEngine;
using System.Collections;

public class ResetBall : MonoBehaviour {

    public GameManagerBowl manager;
    private Vector3 old_position;
    private Vector3 start_position;

	// Use this for initialization
	void Start () {
        start_position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        if (manager.start)
            if (old_position == transform.position)
            {
                print("equal");
                transform.TransformPoint(start_position);
            }
            else
                old_position = transform.position;

	}
}
