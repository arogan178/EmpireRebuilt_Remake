using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSystem : Singleton<AudioSystem>
{
    [SerializeField]
    private AudioSource musicSource;

    [SerializeField]
    private AudioSource soundSource;

    [SerializeField]
    private AudioSource extrasSource;

    public void PlayMusic(AudioClip clip)
    {
        musicSource.clip = clip;
        musicSource.Play();
    }
}
