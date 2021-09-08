using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHandler : MonoBehaviour
{
    public AudioSource audioSource; 

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SoundDelay());
    }

    IEnumerator SoundDelay()
    {
        yield return new WaitForSeconds(2.76f);
        audioSource.Play(0);
    }

}
