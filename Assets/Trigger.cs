using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update

    public int triggerName;

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
            triggerName = 1;
        }
        if (myTrigger.gameObject.name == "2")
        {
            triggerName = 2;
        }
        if (myTrigger.gameObject.name == "3")
        {
            triggerName = 3;
        }
        if (myTrigger.gameObject.name == "4")
        {
            triggerName = 4;
        }
        if (myTrigger.gameObject.name == "5")
        {
            triggerName = 5;
        }
        if (myTrigger.gameObject.name == "6")
        {
            triggerName = 6;
        }
        if (myTrigger.gameObject.name == "7")
        {
            triggerName = 7;
        }
        if (myTrigger.gameObject.name == "8")
        {
            triggerName = 8;
        }
    }

}

