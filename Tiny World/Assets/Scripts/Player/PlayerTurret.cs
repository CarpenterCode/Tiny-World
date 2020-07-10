using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurret : MonoBehaviour
{
    [SerializeField] Transform firePoint;
    [SerializeField] GameObject bulletPrefab;

    float _timer = 1.25f;
    float _setTimer = 1.25f;
    Vector2 mousePos;
    Camera cam;
    Rigidbody2D rb;

    private void Start()
    {
        cam = Camera.main;
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }


    private void Update()
    {

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        _timer -= Time.deltaTime;

        if (Input.GetMouseButtonDown(0) && _timer <= 0)
        {
            Shoot();
        }
    }

    private void FixedUpdate()
    {
        LookThere();
    }


    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.GetComponent<PlayerBullet>().myRange = 3;
        bullet.GetComponent<PlayerBullet>().bulletSpeed = 7;
        _timer = _setTimer;
    }

    void LookThere()
    {
        Vector2 lookDirection = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

}
