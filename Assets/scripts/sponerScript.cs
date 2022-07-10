using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sponerScript : MonoBehaviour
{
   
    int zarib = 0;
    float m = 0f;
    int t = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        m += Time.deltaTime;
        t = (int)m;
        spon();

    }
    void spon()
    {   
        if (t % 3 == 0)
            Instantiate(GameObject.Find("hadf"), new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
        if (t % 3== 1)
         Instantiate(GameObject.Find("hadf1"), new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
    }

}