using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] 
    private Animator animator;

    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(AnimationDelay());
    }

    private IEnumerator AnimationDelay()
    {
        yield return new WaitForSeconds(2.76f);
        animator.SetBool("title", true);
    }
}
