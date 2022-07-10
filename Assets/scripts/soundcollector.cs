using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundcollector : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "dtag")
        {

            Destroy(other.gameObject);
        }

    }
}
