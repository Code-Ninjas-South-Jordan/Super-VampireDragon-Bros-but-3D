using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterController : MonoBehaviour
{

    public float speed = 0.15f;
    public float jumpForce = 10.25f;


    public Rigidbody rb;

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
