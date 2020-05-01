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

    private float moveHorizontal, moveVertical;
    protected float rotY = 0f;

    public bool wife;
    public bool daughter;
    public bool son;


    private void Awake ()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start ()
    {
        rotY = transform.localRotation.eulerAngles.y;
       
    }

    private void FixedUpdate ()
    {
        PlayerMoveKeyboard();
        PlayerMove();
    }

    private void PlayerMoveKeyboard ()
        {
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


    private void PlayerMove ()
    {
    if (moveVertical != 0)
        {
            rb.MovePosition (transform.position + transform.forward * (moveVertical * playerSpeed));
            rotY += moveHorizontal * rotationSpeed;
            rb.rotation = Quaternion.Euler(0f, rotY, 0f);
        }
    else if (moveHorizontal != 0)
        {
            rotY += moveHorizontal * rotationSpeed;
            rb.rotation = Quaternion.Euler(0f, rotY, 0f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
            if(other.gameObject.tag == "Wife")
        {
            wife = true;
        }
            else if(other.gameObject.tag == "Daughter")
        {
            daughter = true;
        }
            else if (other.gameObject.tag == "Son")
        {
            son = true;
        }
            
            

    }

































































}
