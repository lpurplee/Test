using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectController : MonoBehaviour {

    private AudioSource audioSource;

	// Use this for initialization
	void Start ()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (!audioSource.isPlaying)
        {
            Destroy(this.gameObject);
        }
    }

    public void SoundEffectPlay(string name,float volume,Transform parentTransform)
    {
        AudioClip clip = Resources.Load<AudioClip>("AudioSystem/AudioClip/SoundEffectClip/" + name);
        audioSource.clip = clip;
        audioSource.volume = volume > 1 ? 1 : volume;
        audioSource.gameObject.transform.parent = parentTransform;
        audioSource.loop = false;
        audioSource.Play();
    }
}
