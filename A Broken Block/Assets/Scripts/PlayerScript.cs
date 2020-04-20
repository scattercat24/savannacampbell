using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
  public float speedH;
  public float speedV;
  public float speed;

  private Rigidbody rb;
  private float yaw = 0.0f;
  private float pitch = 0.0f;

  void Start (){
    rb = GetComponent<Rigidbody>();
  }
  void FixedUpdate () {
    Move();

    // float vertical = Input.GetAxis("Vertical");
    // float horizontal = Input.GetAxis("Horizontal");
    // Vector3 vel = rb.velocity;
    // vel.z = vertical;
    // vel.x = horizontal;
    // rb.velocity = vel * speed;

    yaw += speedH * Input.GetAxis("Mouse X");
    pitch -= speedV * Input.GetAxis("Mouse Y");


    transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);


  }
  void Move () {
    if (Input.GetKeyDown(KeyCode.UpArrow)) {
      rb.AddRelativeForce(Vector3.forward * speed);
    }
  }

}
