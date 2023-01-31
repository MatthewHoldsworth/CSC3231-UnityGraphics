using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    //all serialized so that they can be adjusted, rotation in seconds
    [SerializeField]
    float rotationX;
    [SerializeField]
    float rotationY;
    [SerializeField]
    float rotationZ;

    // Update is called once per frame
    void Update()
    {
        //rotate object by its rotation values times time passed since last frame
        this.transform.Rotate(rotationX * Time.deltaTime, rotationY * Time.deltaTime, rotationZ * Time.deltaTime, Space.World);
    }
}
