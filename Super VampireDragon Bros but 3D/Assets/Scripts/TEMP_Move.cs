using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEMP_Move : MonoBehaviour
{
    float speed = 0.1f;

    public float jumpForce = 14;
    public Rigidbody rb;

    public bool isGrounded = true; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
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
