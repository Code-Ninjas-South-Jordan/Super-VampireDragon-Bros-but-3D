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


    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(AnimationDelay());
        StartCoroutine(SpaceCheck());
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
        if(Input.GetKeyDown("space"))
        {
            animator.SetBool("spaceKey", true);
            Invoke("CallAudio", 0.89f);
            Invoke("NextScene", 0.1f;)
        }
    }

    void CallAudio()
    {
        audioSource.PlayOneShot(clip2, 0.89f);
    }

    void NextScene()
    {
        SceneManager.LoadScene(1);
    }
}
