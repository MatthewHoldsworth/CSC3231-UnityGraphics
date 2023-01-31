using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    //mouse sensitivity
    [SerializeField]
    float xSpeed;
    [SerializeField]
    float ySpeed;

    //starting rotion of camera
    float yRotation = 0.0f;
    float xRotation = 0.0f;


    // Update is called once per frame
    void Update()
    {
        //increments x and y rotation based on mouse axis movement
        xRotation += Input.GetAxis("Mouse X") * xSpeed * Time.deltaTime;
        yRotation += Input.GetAxis("Mouse Y") * ySpeed * Time.deltaTime;
        //updates euler angles to set rotation
        transform.localEulerAngles = new Vector3(-yRotation, xRotation, 0);
    }
}
