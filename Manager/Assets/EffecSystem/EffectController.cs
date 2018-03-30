using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectController : MonoBehaviour
{
    private ParticleSystem ps;
    private void Start()
    {
        ps = this.gameObject.GetComponent<ParticleSystem>();
        ParticleSystem.MainModule pm = ps.main;
        pm.playOnAwake = true;
    }
    private void Update()
    {
        if (!ps.isPlaying)
        {
            Destroy(gameObject);
        }
    }

}
