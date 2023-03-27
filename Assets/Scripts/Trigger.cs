using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
<<<<<<< HEAD
=======
    private IEnumerator coroutine;
    public GameObject Cylinder;
    private float speed = 2f;
>>>>>>> parent of 9ed5680 (Revert "123")
    // Start is called before the first frame update

    public int triggerName;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider myTrigger)
    {
        if (myTrigger.gameObject.name == "1")
        {
            Cylinder.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
    void OnTriggerEnter(Collider myTrigger)
    {
        if (myTrigger.gameObject.name == "1")
        {
<<<<<<< HEAD
            triggerName = 1;
=======
            
>>>>>>> parent of 9ed5680 (Revert "123")
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
    private void OnTriggerExit(Collider myTrigger)
    {
        if (myTrigger.gameObject.name == "1")
        {
            StopAllCoroutines();
        }
    }
    private IEnumerator Transport(float waitTime)
    {
        while (true)
        {
            Cylinder.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

    }
}

