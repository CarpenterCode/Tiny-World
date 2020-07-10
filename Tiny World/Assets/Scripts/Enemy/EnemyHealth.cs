using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int health;
    bool isDead;

    private void Update()
    {
        if (health <= 0 && isDead == false)
        {
            DieHere();
        }
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
    }


    void DieHere()
    {
        isDead = true;
        this.gameObject.GetComponent<DieScript>().MinusEnemy();
        Destroy(this.gameObject);
    }
}
