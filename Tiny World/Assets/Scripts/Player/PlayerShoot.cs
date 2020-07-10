
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public bool pistol, smg, shotgun;

    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform firePoint;

    float _timer = 0.5f;
    float _setTimer = 0.5f;

    private void Update()
    {
        _timer -= Time.deltaTime;

        if (Input.GetMouseButton(0) && _timer <= 0)
        {
            ShootBullet();
        }

    }

    void ShootBullet()
    {
        if (pistol == true)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            bullet.GetComponent<PlayerBullet>().bulletSpeed = 12;
            bullet.GetComponent<PlayerBullet>().myRange = 7;
            _setTimer = 0.5f;
            _timer = _setTimer;
        }
        
        if (smg == true)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            bullet.GetComponent<PlayerBullet>().bulletSpeed = 9;
            bullet.GetComponent<PlayerBullet>().myRange = 17;
            _setTimer = 0.17f;
            _timer = _setTimer;
        }

        if (shotgun == true)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            bullet.GetComponent<PlayerBullet>().bulletSpeed = 7;
            bullet.GetComponent<PlayerBullet>().myRange = 27;
            GameObject bullet2 = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            bullet2.GetComponent<PlayerBullet>().bulletSpeed = 7;
            bullet2.GetComponent<PlayerBullet>().myRange = 27;
            GameObject bullet3 = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            bullet3.GetComponent<PlayerBullet>().bulletSpeed = 7;
            bullet3.GetComponent<PlayerBullet>().myRange = 27;
            GameObject bullet4 = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            bullet4.GetComponent<PlayerBullet>().bulletSpeed = 7;
            bullet4.GetComponent<PlayerBullet>().myRange = 27;
            GameObject bullet5 = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            bullet5.GetComponent<PlayerBullet>().bulletSpeed = 7;
            bullet5.GetComponent<PlayerBullet>().myRange = 27;
            _setTimer = 1.2f;
            _timer = _setTimer;
        }
    }
}
