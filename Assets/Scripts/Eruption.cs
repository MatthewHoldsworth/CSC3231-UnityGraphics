using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eruption : MonoBehaviour
{
    //time till eruption
    [SerializeField]
    float fuse;
    //gets sky so that it can be disabled
    [SerializeField]
    GameObject sky;
    //gets weather so that it can be disabled
    [SerializeField]
    GameObject Weather;
    //set whether the volcano should be active
    [SerializeField]
    bool active;

    //counter to time the fuse
    float counter = 0;

    // Update is called once per frame
    void Update()
    {
        //enumerates counter
        counter += Time.deltaTime;
        //checks if active and fuse time has passed
        if (fuse < counter && active)
        {
            Erupt();
        }
    }

    //suppose to enable and siable grpahical feratures to make the volcanoe loke its erupting
    void Erupt()
    {
        //disable sky
        sky.SetActive(false);
        //disable weather
        Weather.SetActive(false);
        //set child graphic objects to active
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(true);
        transform.GetChild(2).gameObject.SetActive(true);
    }
}
