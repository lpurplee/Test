using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgController : MonoBehaviour
{
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        this.gameObject.transform.position = Vector3.zero;
        audioSource.spatialBlend = 0;
    }

    public void BgPlay(float volume)
    {
        audioSource.volume = volume > 1 ? 1 : volume;
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
    public void BgPlay(string bgName,float volume)
    {
        AudioClip audioClip = Resources.Load<AudioClip>("AudioSystem/AudioClip/BgClip"+bgName);
        audioSource.volume = volume > 1 ? 1 : volume;
        audioSource.loop = false;
        audioSource.Play();
    }

    public void BgPause()
    {
        audioSource.Pause();
    }
    public void BgUnPause()
    {
        audioSource.UnPause();
    }

}
