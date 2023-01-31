using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day : MonoBehaviour
{
    //how long it takes for one full rotation
    [SerializeField]
    float timing;
    //sets the lamppost system
    [SerializeField]
    LamppostSystem lamppostSystem;

    //position in sky
    float position;
    //speed of rotaion out of 1
    float cycle;
    //speed of rotaion out of 360
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        //calculate speeds
        speed = 360 / timing;
        //cycle is twice as quick as its used for sun set and rise, therefore occurs twice in one rotion
        cycle = 1 / timing * 2;
        //sets position to 0.5, midday
        position = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        //enumerates position and rotation via there speeds
        position += cycle * Time.deltaTime;
        transform.Rotate(speed * Time.deltaTime, 0f, 0f, Space.World);
        //changes time once the sun or mooon has set
        if (position > 1)
        {
            //reset position and change lights
            position = 0f;
            ChangeTime();
        }
    }

    //calls the lamppost system method to alternate lights
    void ChangeTime()
    {
        lamppostSystem.AlternateLights();
    }
}
