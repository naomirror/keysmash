using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayerVolume : MonoBehaviour
{

    
    private AudioSource audioSrc;

    
    
    private float musicVolumeCurrent = 1f;

    
    void Start()
    {

       
        audioSrc = GetComponent<AudioSource>();
    }

    
    void Update()
    {

        audioSrc.volume = musicVolumeCurrent;
    }

    public void SetVolume(float vol)
    {
        musicVolumeCurrent = vol;
    }
}
