using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    public bool flagged;

    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("Win", false);
        animator.enabled = false;
        flagged = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if(other.tag == "Flag"){
            StartCoroutine(FlagDelay());
        }
    }

    private IEnumerator FlagDelay(){
        animator.enabled = true;
        animator.SetBool("Win", true);
        yield return new WaitForSeconds(2f);
        flagged = true;
    }
}
