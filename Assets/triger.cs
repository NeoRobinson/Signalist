using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider myTrigger) 
    { 
        if (myTrigger.gameObject.name == "1") 
        { 
            Debug.Log("1");
        }
        if (myTrigger.gameObject.name == "2")
        {
            Debug.Log("2");
        }
        if (myTrigger.gameObject.name == "3")
        {
            Debug.Log("3");
        }
        if (myTrigger.gameObject.name == "4")
        {
            Debug.Log("4");
        }
        if (myTrigger.gameObject.name == "5")
        {
            Debug.Log("5");
        }
        if (myTrigger.gameObject.name == "6")
        {
            Debug.Log("6");
        }
        if (myTrigger.gameObject.name == "7")
        {
            Debug.Log("7");
        }
        if (myTrigger.gameObject.name == "8")
        {
            Debug.Log("8");
        }
    }
}