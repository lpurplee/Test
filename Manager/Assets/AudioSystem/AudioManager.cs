using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager
{
    private GameObject bgPlayer;
    private BgController bgController;

    private AudioManager()
    {
        if (bgPlayer == null)
        {
            bgPlayer = GameObject.Instantiate<GameObject>(Resources.Load("AudioSystem/Prefabs/"+"BgCtrl") as GameObject);
            bgController = bgPlayer.GetComponent<BgController>();
        }
    }

    private static AudioManager instance;

    public static AudioManager GetInstance
    {
        get
        {
            if (instance == null)
            {
                instance = new AudioManager();
            }
            return instance;
        }
    }

    private AudioSource bgAudioSource;

    public void BgPlay(string bgName,float volume)
    {
        bgController.BgPlay(bgName, volume);
    }
    public void BgPause()
    {
        bgController.BgPause();
    }
    public void BgGoOn()
    {
        bgController.BgUnPause();
    }


    //private List<AudioManager> audioList = new List<AudioManager>();
    public void SoundEffect(string name,float volume,Transform parentTrans)
    {
        GameObject seGo = GameObject.Instantiate<GameObject>(Resources.Load<GameObject>("AudioSystem/Prefabs"+"SoundEffectCtrl"));
        SoundEffectController seController = seGo.GetComponent<SoundEffectController>();
        seController.SoundEffectPlay(name,volume,parentTrans);
    }

}
