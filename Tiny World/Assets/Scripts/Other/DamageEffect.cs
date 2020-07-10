using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEffect : MonoBehaviour
{
    
    public void ActivateEffect()
    {
        this.gameObject.SetActive(true);
    }

    public void DeactivateEffect()
    {
        this.gameObject.SetActive(false);
    }





}
