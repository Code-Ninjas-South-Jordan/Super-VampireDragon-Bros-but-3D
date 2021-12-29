using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterController : MonoBehaviour
{
    public float speed = 3f;
    public float jumpForce = 14;
    public Rigidbody rb;

    public bool isGrounded = true; 

    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate(){
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");  
        this.transform.Translate(-vertical * speed, 0, horizontal * speed);

        if(Input.GetKeyDown("space") && isGrounded){
            rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision collision){
        if(collision.collider.tag == "Ground"){
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision){
        if(collision.collider.tag == "Ground"){
            isGrounded = false;
        }
    }
}
