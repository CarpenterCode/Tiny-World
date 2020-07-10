using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] float shotSpeed, _setTimer;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform firePoint;

    float _timer = 1.2f;


    private void Update()
    {
        _timer -= Time.deltaTime;
        if (_timer < 0)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
        bulletRB.AddForce(firePoint.up * shotSpeed, ForceMode2D.Impulse);
        Destroy(bullet, 5);
        _timer = _setTimer;
    }
}
