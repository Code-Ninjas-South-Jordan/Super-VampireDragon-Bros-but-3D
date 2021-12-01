using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterController : MonoBehaviour
{
    public float speed = 3f;

    void FixedUpdate(){
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        this.transform.position += new Vector3(-vertical * speed, 0, horizontal * speed);
    }
}
