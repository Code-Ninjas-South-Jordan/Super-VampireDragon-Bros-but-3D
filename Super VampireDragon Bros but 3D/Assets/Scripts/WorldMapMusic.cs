using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMapMusic : MonoBehaviour
{
    public AudioSource audioSource;
    public Map level;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.Play(0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void PlayMusic()
    {
        if(level.Level == 1)
        {
            audioSource.Play(0);
        }
        else if(level.Level == 2)
        {

        }
    }
}
