using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherSystem : MonoBehaviour
{
    //interval at which a weather effect will happen
    [SerializeField]
    float interval;
    //Array of all weather effects in the scene
    [SerializeField]
    WeatherElement[] elements;

    float counter;

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if(counter > interval)
        {
            counter = 0;
            //randomly selects which weather effect to select
            elements[Random.Range(0, elements.Length)].Activate();
        }
    }
}
