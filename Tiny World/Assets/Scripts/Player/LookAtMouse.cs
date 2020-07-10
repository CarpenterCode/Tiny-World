using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] Vector3 offSetPosition;

    Rigidbody2D rb;
    Vector2 mousePos;
    Camera cam;

    private void Start()
    {
        cam = Camera.main;
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }


    private void FixedUpdate()
    {
        LookThere();
        FollowPlayer();
    }

    void LookThere()
    {
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg + 90f;
        rb.rotation = angle;
    }

    void FollowPlayer()
    {
        rb.transform.position = (new Vector3(playerTransform.position.x, playerTransform.position.y) + offSetPosition);
    }
}
