using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public MyCharacterController controller;

    void Start(){
        controller.dead = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(!controller.dead){
            transform.position = new Vector3(player.transform.position.x + 10f, player.transform.position.y + 5f, player.transform.position.z);
        }
    }

}
