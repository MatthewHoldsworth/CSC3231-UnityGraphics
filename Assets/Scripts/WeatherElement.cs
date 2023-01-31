using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherElement : MonoBehaviour
{
    //length in seconds of rain
    [SerializeField]
    float length;

    //counter to time the length
    float counter = 0;

    // Update is called once per frame
    void Update()
    {
        //enumerates counter
        counter += Time.deltaTime;
        //checks if length has been passed
        if (length < counter)
        {
            transform.gameObject.SetActive(false);
        }
    }

    public void Activate()
    {
        transform.gameObject.SetActive(true);
    }

}
