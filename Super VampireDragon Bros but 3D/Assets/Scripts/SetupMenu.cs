using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SetupMenu : MonoBehaviour
{
    public AudioSource audioSource;
    [SerializeField]
    private AudioClip clip;

    private void PlayGame()
    {
        SceneManager.LoadScene(2);
    }

    public void PlaySound()
    {
        audioSource.PlayOneShot(clip, 0.7f);
        Invoke("PlayGame", 0.1f);
    }

}
