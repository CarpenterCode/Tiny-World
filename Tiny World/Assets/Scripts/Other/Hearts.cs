using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;
using UnityEngine.UI;

public class Hearts : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Image heart1, heart2, heart3;

    int health;


    private void Update()
    {

        health = player.GetComponent<Health>().hitPoints;

        if (health == 2)
        {
            TakeOneDamage();
        }
        if (health == 1)
        {
            TakeTwoDamage();
        }
        if (health == 0)
        {
            TakeThreeDamage();
        }
    }

    void TakeOneDamage()
    {
        heart3.enabled = false;
    }
    void TakeTwoDamage()
    {
        heart2.enabled = false;
    }
    
    void TakeThreeDamage()
    {
        heart1.enabled = false;
    }

}
