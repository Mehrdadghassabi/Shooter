using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class textscript : MonoBehaviour
{
    public int emtiaz = 0;

    [SerializeField]
    private GameObject Y;

    int X;
    public Text score;
    //in ejezemide toye flied zaher she

    // add nothing to this one bcuz it get its component
    private tir Z;
    /*this one is a object that u get ur component from add tir game object the flied will be apear in object settings or smth panel */


    // Use this for sinitialization
    void Start()
    {
        Z = Y.GetComponent<tir>();
       

    }

    // Update is called once per frame
    void Update()
    {
        
        score.text = "Score:"+emtiaz.ToString();
       // Debug.Log(GameObject.Find("Text").GetComponent<textscript>().emtiaz);
    }
}

