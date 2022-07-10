using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class texttimescript : MonoBehaviour
{
    int t;
    int min = 0;
    int sec = 0;
    float timer = 0;
    public Text zaman;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        t = (int)timer;
        sec = t % 60;
        min = (int)(t / 60);

        if(sec<10)
        zaman.text ="Time: "+ min.ToString()+":0"+sec.ToString();

        else
            zaman.text = "Time: " + min.ToString() + ":" + sec.ToString();
        
    }
}