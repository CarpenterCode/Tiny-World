using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] GameObject redScreen, ouch1, ouch2;
    public int hitPoints = 3;

    float timer;
    float setTimer = 0.15f;

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            redScreen.SetActive(false);
        }
    }
    public void TakeDamage()
    {
        if (hitPoints > 0)
        {
            hitPoints--;
            redScreen.SetActive(true);
            timer = setTimer;
            int chance = Random.Range(0, 1);
            if (chance == 0)
            {
                GameObject sound1 = Instantiate(ouch1, transform.position, Quaternion.identity);
                Destroy(sound1, 1);
            }
            if (chance == 1)
            {
                GameObject sound2 = Instantiate(ouch2, transform.position, Quaternion.identity);
                Destroy(sound2, 1);
            }
        }
        if (hitPoints <= 0)
        {
            this.gameObject.GetComponent<DieScript>().YouLost();
        }
    }
    
}
