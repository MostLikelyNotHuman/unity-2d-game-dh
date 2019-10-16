using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioSource collectOneAudioSource;

    public AudioSource collectAllAudioSource;

    public AudioClip coinCollectSound;

    public AudioClip coinCollectAllSound;

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
        collectOneAudioSource.clip = coinCollectSound;
        collectOneAudioSource.Play();
    }

    public void PlayCoinCollectAllSound()
    {
        collectAllAudioSource.clip = coinCollectAllSound;
        collectAllAudioSource.Play();
    }
}
