using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public GameObject floor;


    public float speed;
    public int dir;

	private float limit;

	// Use this for initialization
	void Start () {
		limit = floor.transform.localScale.x/2 - transform.localScale.x;
		print ("Limit: " + limit);
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.x > limit)
        {
            dir = -1;
        }
        if(transform.position.x < -limit)
            dir = 1;
        
		//Curve Movement
		//transform.RotateAround(new Vector3(0,0,0), new Vector3(0,dir*20,0), speed);
        //Lineal Movement
		transform.Translate(new Vector3(speed*dir,0,0));

	}
}
