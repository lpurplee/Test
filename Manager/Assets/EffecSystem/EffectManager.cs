using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager
{
    private static EffectManager instance;
    public static EffectManager GetInstance()
    {
        if (instance==null)
        {
            instance = new EffectManager();
        }
        return instance;
    }

    
    public void CreatEffect(string effectName,Transform parentTrans)
    {
        GameObject go = Resources.Load<GameObject>("EffectSystem/" + "" + effectName);
        GameObject effectGo = GameObject.Instantiate(go);
        effectGo.transform.parent = parentTrans;
        EffectController effectManager = effectGo.GetComponent<EffectController>();
        
    }

}
