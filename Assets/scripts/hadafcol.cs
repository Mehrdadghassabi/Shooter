using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hadafcol : MonoBehaviour {
    float a = 0;
    int counter = 0;
    private void Start()
    {
        transform.Translate(Random.Range(-8f, 8f), Random.Range(1f, 4f), 0);

    }
    private void Update()
    {
        movement();
        counter++;
    }
    
    void movement()
    {
        if (counter % 3 == 0)
            a = Random.Range(-0.2f, 0.2f);
        else
            a = 0;
            transform.Translate(a, -0.015f, 0);
       

    }
}
