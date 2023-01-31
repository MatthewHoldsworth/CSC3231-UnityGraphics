using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueMovement : MonoBehaviour
{
    //all serialized so that they can be adjusted, movement in seconds
    [SerializeField]
    float MinY;
    [SerializeField]
    float MaxY;
    [SerializeField]
    float MinPosY;
    [SerializeField]
    float MaxPosY;

    // Update is called once per frame
    void Update()
    {
        //transform.position.y = transform.position.y;
    }
}
