using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    //speed per seconds movement of the camera
    [SerializeField]
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        //lock and hide cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //calculate movement based on movement axis multiplied by speed
        var translationV = Input.GetAxis("Vertical") * speed;
        var translationH = Input.GetAxis("Horizontal") * speed;

        //Input keys to move camera and translate position by translation times time
        if (Input.GetKey("w"))
        {
            transform.Translate(0, 0, translationV * Time.deltaTime);
        }
        else if (Input.GetKey("s"))
        {
            transform.Translate(0, 0, translationV * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(translationH * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("d"))
        {
            transform.Translate(translationH * Time.deltaTime, 0, 0);
        }
    }
}
