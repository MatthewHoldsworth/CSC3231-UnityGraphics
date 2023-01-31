using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LamppostSystem : MonoBehaviour
{
    //Stores it children in an array
    Lamppost[] children;

    void Start()
    {
        //gets all children via there Lamppost script component
        children = GetComponentsInChildren<Lamppost>();
    }

    //Turns lights off if on, and on if off
    public void AlternateLights()
    {
        //loops throught children array and alternates there light
        foreach (Lamppost lamp in children)
        {
            lamp.AlternateLight();
        }
    }
}
