using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
  public float speed;
  public Text countText;
  public Text winText;

  private Rigidbody rb;
  private int count;

  void Start () {
    rb = GetComponent<Rigidbody>();
    count = 0;
    SetCountText();
    winText.text = " ";
  }
  void FixedUpdate () {
    float translation = Input.GetAxisRaw("Vertical");
    float rotation = Input.GetAxisRaw("Horizontal");

    rb.AddForce(rotation, 0, translation * speed, ForceMode.Impulse);
  }
  void OnTriggerEnter(Collider other) {
    if (other.gameObject.CompareTag("Pick Up")) {
      other.gameObject.SetActive (false);
      count = count + 1;
      SetCountText();
    }
  }

  void SetCountText () {
    countText.text = "Count: " + count.ToString ();
    if (count >= 11) {
      winText.text = "You Win";
    }

  }

} //class
