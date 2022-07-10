using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class tir : MonoBehaviour {


    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0.1f, 0);
        
    }

  private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "hadftag")
        {
            Instantiate(GameObject.Find("sound"), new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);

            Destroy(other.gameObject);
            Destroy(gameObject);
            GameObject.Find("Text").GetComponent<textscript>().emtiaz += 5;
 
        }

        if (other.tag == "hadf1tag")
        {
            Destroy(other.gameObject);
            GameObject.Find("Text").GetComponent<textscript>().emtiaz -= 1;
           
        }

    }

}
