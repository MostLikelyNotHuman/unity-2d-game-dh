using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioSource audioSource;
    public AudioSource winAudioSource;

    public AudioClip coinCollectSound;
    public AudioClip coinCollectAllSound;
    public AudioClip deathSound;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

        Instance = this;
    }

    public void PlayCoinCollectSound()
    {
        audioSource.clip = coinCollectSound;
        audioSource.Play();
    }

    public void PlayCoinCollectAllSound()
    {
        winAudioSource.clip = coinCollectAllSound;
        winAudioSource.Play();
    }

    public void PlayDeathSound()
    {
        audioSource.clip = deathSound;
        audioSource.Play();
    }

}


