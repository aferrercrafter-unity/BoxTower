using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {

    public GameManager gameManager;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision colDAta)
    {
        if (gameManager.boxs > 1){
            Destroy(colDAta.gameObject);
            gameManager.boxs--;
            Camera.main.transform.Translate(Vector3.down);
        }        
    }
}
