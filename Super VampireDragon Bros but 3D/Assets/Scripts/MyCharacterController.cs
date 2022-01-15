using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterController : MonoBehaviour
{
    public float speed = 0.15f;
    public float jumpForce = 10.25f;


    public Rigidbody rb;

    public bool isGrounded = true; 
    public bool dead;

    public Vector3 startPos;

    void Start(){
        rb = GetComponent<Rigidbody>();
        startPos = transform.position;
    }

    void FixedUpdate(){
        if(!dead){
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");  
            this.transform.Translate(-vertical * speed, 0, horizontal * speed);
        }

    }

    void Update(){
        if(Input.GetKeyDown("space") && isGrounded){
            rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision collision){
        if(collision.collider.tag == "Ground"){
            isGrounded = true;
        }
        else if(collision.collider.tag == "Death"){

        }
    }

    void OnCollisionExit(Collision collision){
        if(collision.collider.tag == "Ground"){
            isGrounded = false;
        }
    }

    void OnTriggerEnter(Collider other){
        if(other.tag == "Death"){
            dead = true;
            StartCoroutine(DeathDelay());
        }
    }

    IEnumerator DeathDelay(){
        yield return new WaitForSeconds(2f);
        transform.position = startPos;
        dead = false;
    }
}
