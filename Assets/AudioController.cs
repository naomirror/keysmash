using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

    public Settings Settings;
    public bool PlayOnAwake = false;
    public bool PlayOnStart = true;

    private AudioSource src;

    private void Awake()
    {
        src = GetComponent<AudioSource>();
        if (PlayOnAwake)
            Play();
    }

    private void Start ()
    {
        if (PlayOnStart)
            Play();
    }

    private void Play()
    {
        src.volume = Settings.Volume;
        src.Play();
    }

    private void Update()
    {
        src.volume = Settings.Volume;
    }
}
