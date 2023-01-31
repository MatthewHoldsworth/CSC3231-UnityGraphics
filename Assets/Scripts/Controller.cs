using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField]
    float timing;

    float counter;

    List<GameObject> lampposts;

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if (counter > timing)
        {
            
        }
    }

    void TurnOffLights()
    {

    }

    void GetAllLampposts()
    {

    }
}
