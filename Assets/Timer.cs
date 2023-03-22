using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public Trigger _trigger;
    public float timerStart = 2;
    public float[] mass;
    private int firstTriggerName;
    private int secondTriggerName;

    void Start()
    {
        firstTriggerName = _trigger.triggerName;
    }
    private void Update()
    {
        secondTriggerName = _trigger.triggerName;

        if (firstTriggerName == secondTriggerName && timerStart != 0)
        {
            timerStart -= Time.deltaTime;
        }
        else
        {
            _trigger.triggerName = 1;
        }
    }
}