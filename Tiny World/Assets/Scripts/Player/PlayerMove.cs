using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] float moveSpeed;
    

    Vector2 mousePos;
    Camera cam;
    Rigidbody2D rb;
    float moveX;
    float moveY;

    private void Start()
    {
        cam = Camera.main;
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        MovePlayer();
        //RotatePlayer();
    }


    void MovePlayer()
    {
        rb.MovePosition(rb.position + new Vector2(moveX, moveY) * moveSpeed * Time.fixedDeltaTime);
    }

    void RotatePlayer()
    {
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg + 90f;
        rb.rotation = angle;
    }
}
