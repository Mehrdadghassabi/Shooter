using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hortircollector : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "tirhortag")
        {

            Destroy(other.gameObject);
        }

    }
}
