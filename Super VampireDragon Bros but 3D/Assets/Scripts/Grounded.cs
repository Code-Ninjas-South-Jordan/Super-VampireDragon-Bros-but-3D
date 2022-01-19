using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    public Rigidbody playerRb;
    public MyCharacterController controller;
    public bool isGrounded;

    void Update(){
        if(Input.GetButtonDown("Jump") && isGrounded){
            playerRb.AddForce(0, controller.jumpForce, 0, ForceMode.Impulse);
        }
    }

     void OnTriggerEnter(Collider other){
        if(other.tag == "Ground"){
            isGrounded = true;
        }
    }

    void OnTriggerExit(Collider other){
        if(other.tag == "Ground"){
            isGrounded = false;
        }
    }
}
