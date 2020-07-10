using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeScreen : MonoBehaviour
{
    [SerializeField] Animator myAnimator;

    public void ShakeMyCamera()
    {
        int randShake = Random.Range(0, 4);

        switch (randShake)
        {
            case 0:
                myAnimator.SetTrigger("Shake1");
                break;
            case 1:
                myAnimator.SetTrigger("Shake2");
                break;
            case 2:
                myAnimator.SetTrigger("Shake3");
                break;
            case 3:
                myAnimator.SetTrigger("Shake4");
                break;
        }
    }
    
    public void DamageShake()
    {
        myAnimator.SetTrigger("DamageTrigger");
    }

}
