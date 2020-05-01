using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : PlayerScript
{
    public Transform target;
    private Rigidbody myBody;

    void Awake () {
      myBody = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        transform.position = target.position;
        myBody.rotation = target.rotation;


    }
}
