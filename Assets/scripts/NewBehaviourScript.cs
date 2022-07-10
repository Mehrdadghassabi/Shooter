using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    
    [SerializeField]
    private int a = 0;
    [SerializeField]
    private int counter = 1;
    [SerializeField]
    private AudioSource seda;
    [SerializeField]
    private AudioSource seda1;

    // Use this for initialization
    void Awake()
    {
  
        
    }
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.x>-8.55&& transform.position.x < 8.55)
        movement();

        else
        {
            if(transform.position.x >= 8.55)
                transform.Translate(-0.01f, 0, 0);

            if (transform.position.x <= -8.55)
                transform.Translate(+0.01f, 0, 0);

        }
        
            if(Input.GetKeyDown(KeyCode.F))
            cloner();

        if (Input.GetKeyDown(KeyCode.G))
            cloner1();

        if (GameObject.Find("Text").GetComponent<textscript>().emtiaz > 10000)
            Debug.Log("you win");
        
    }
    void movement()
    {
        if(Input.GetAxis("Mouse X") < 0)
        {
            transform.Translate(-0.15f, 0, 0);
        }
        if (Input.GetAxis("Mouse X") > 0)
        {
            transform.Translate(0.15f, 0, 0);
        }

    }
    void cloner()
    {
 
            Instantiate(GameObject.Find("Tir"), new Vector3(transform.position.x-0.5f, transform.position.y + 0.5f, 0), Quaternion.identity);
        Instantiate(GameObject.Find("Tir"), new Vector3(transform.position.x+0.5f, transform.position.y + 0.5f, 0), Quaternion.identity);

    }

    void cloner1()
    {

        Instantiate(GameObject.Find("tirhor"), new Vector3(transform.position.x + 0.7f, transform.position.y, 0), Quaternion.identity);
        Instantiate(GameObject.Find("tirhor1"), new Vector3(transform.position.x - 0.7f, transform.position.y, 0), Quaternion.identity);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       

        if (other.tag == "hadf1tag")
        {
            Destroy(other.gameObject);
            GameObject.Find("Text").GetComponent<textscript>().emtiaz += 5;

            seda.Play();

        }

        if (other.tag == "hadftag" && counter == 4)
        {
            Destroy(GameObject.Find("player"));
            seda1.Play();

        }

        if (other.tag == "hadftag" && counter == 3)
        {
            Destroy(GameObject.Find("joon3"));
            Destroy(other.gameObject);
            seda1.Play();

            counter++;
        }

        if (other.tag == "hadftag" && counter == 2)
        {
            Destroy(GameObject.Find("joon2"));
            Destroy(other.gameObject);
            seda1.Play();

            counter++;
        }

        if (other.tag == "hadftag"&& counter==1)
        {
            Destroy(GameObject.Find("joon1"));
            Destroy(other.gameObject);
            seda1.Play();

            counter++;
        }

       

    }


}
