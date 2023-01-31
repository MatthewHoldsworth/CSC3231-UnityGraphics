using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamppost : MonoBehaviour
{
    //has there light source on init
    GameObject lightSource;

    void Start()
    {
        //gets there light source
        lightSource = transform.GetChild(0).GetChild(0).gameObject;
    }

    public void AlternateLight()
    {
        //sets lightsource to active depending on if it were already active
        lightSource.SetActive(!(lightSource.activeSelf));
    }
}
