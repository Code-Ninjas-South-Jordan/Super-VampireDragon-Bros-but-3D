using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationController : MonoBehaviour
{
    [SerializeField] 
    private Animator animator;
    public AudioClip clip;
    public AudioClip clip2;
    public AudioSource audioSource;
    public GameObject pressSpace;
    bool spaceKey = false;


    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(AnimationDelay());
    }

    private IEnumerator AnimationDelay()
    {
        yield return new WaitForSeconds(0.9f);
        audioSource.PlayOneShot(clip, 0.7f);
        yield return new WaitForSeconds(1.86f);
        animator.SetBool("title", true);
        yield return new WaitForSeconds(1f);
        animator.SetBool("text (space)", true);
    }

    void Update()
    {
        if(!spaceKey)
        {
            animator.Play("Change Size - Forever");
        }
        else if(spaceKey)
        {
            animator.Play("Start");
            audioSource.PlayOneShot(clip2, 0.7f);
            SceneManager.LoadScene(1);
        }

        if(Input.GetKeyDown("space"))
        {
            if(spaceKey)
            {
                spaceKey = false;
            } else if(!spaceKey)
            {
                spaceKey = true; 
            }
           
        }
    }
}
