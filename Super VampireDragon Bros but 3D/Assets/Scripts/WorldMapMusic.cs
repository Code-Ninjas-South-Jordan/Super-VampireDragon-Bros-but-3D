using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMapMusic : MonoBehaviour
{
    public AudioSource audioSource;
    public Map level;
    public AudioClip World2;
    public AudioClip World3;
    public AudioClip World4;
    public AudioClip World5;
    public AudioClip World6;
    public AudioClip World7;
    public AudioClip World8;
    public AudioClip World9;
    public AudioClip World10;


    // Start is called before the first frame update
    void Start()
    {
        PlayMusic();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void PlayMusic()
    {
        if(level.Level == 1)
        {
            
        }
        else if(level.Level == 2)
        {
            audioSource.PlayOneShot(World2, 0.7f);
        }
    }
}
