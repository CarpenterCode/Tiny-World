using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    Rigidbody2D rb;
    Transform target;
    Vector2 movement;


    private void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        FollowHim();
    }

    private void FixedUpdate()
    {
        MoveThere(movement);
    }

   
    void FollowHim()
    {
        Vector2 lookDir = target.position - rb.transform.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
        lookDir.Normalize();
        movement = lookDir;
    }

    void MoveThere(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.fixedDeltaTime));
    }
}
