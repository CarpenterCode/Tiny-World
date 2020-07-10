using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float bulletSpeed, myRange;

    Rigidbody2D rb;


    private void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        ShootBullet(myRange, bulletSpeed);
    }


    void ShootBullet(float myRange, float bulletSpeed)
    {
            rb.transform.Rotate(0, 0, Random.Range(-myRange, myRange));
            rb.velocity = transform.up * bulletSpeed;
    }
}
