using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
  private Rigidbody rb;
  private Animator anim;

  private bool isPlayerMoving;

  private float playerSpeed = 0.5f;
  private float rotationSpeed = 4f;

  private float jumpForce = 3f;
  private bool canJump;

  private float moveHorizontal, moveVertical;
  protected float rotY = 0f;


  void Awake () {
    rb = GetComponent<Rigidbody>();
  }

  void Start () {
        rotY = transform.localRotation.eulerAngles.y;
       
  }

  void FixedUpdate () {
    PlayerMoveKeyboard();
    PlayerMove();
  }

  void PlayerMoveKeyboard () {
    if (Input.GetKeyDown(KeyCode.LeftArrow)) {
      moveHorizontal = -1;
    }
    if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)) {
      moveHorizontal = 0;
    }
    if (Input.GetKeyDown(KeyCode.RightArrow)) {
      moveHorizontal = 1;
    }
    if (Input.GetKeyDown(KeyCode.UpArrow)) {
      moveVertical = 1;
    }
    if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow)) {
      moveVertical = 0;
    }
    if (Input.GetKeyDown(KeyCode.DownArrow)) {
      moveVertical = -1;
    }
  }


void PlayerMove () {
  if (moveVertical != 0) {
    rb.MovePosition (transform.position + transform.forward * (moveVertical * playerSpeed));
    rotY += moveHorizontal * rotationSpeed;
    rb.rotation = Quaternion.Euler(0f, rotY, 0f);
  }
  else if (moveHorizontal != 0) {
      rotY += moveHorizontal * rotationSpeed;
      rb.rotation = Quaternion.Euler(0f, rotY, 0f);
  }
}

































    
































}
