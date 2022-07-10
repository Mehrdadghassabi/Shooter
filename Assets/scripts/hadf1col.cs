using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hadf1col : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.Translate(Random.Range(-8f,8f), Random.Range(1f, 4f), 0);
    }
	
	// Update is called once per frame
	void Update () {
       
        movement();
    }
    void movement()
    {

        transform.Translate(Random.Range(-0.2f, 0.2f), -0.015f, 0);


    }
}
