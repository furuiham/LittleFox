using UnityEngine;

public class PlayerController : MonoBehaviour {
    public Rigidbody2D rigidbody2D;
    public float speed = 350;
    public float jumpForce;

    void Start() { }

    void FixedUpdate() {
        Movement();
    }

    public void Movement() {
        float horizontalMove;
        horizontalMove = Input.GetAxis("Horizontal");

        float faceDirection = Input.GetAxisRaw("Horizontal");

        Debug.Log(horizontalMove);

        if (horizontalMove != 0) {
            rigidbody2D.velocity = new Vector2(horizontalMove * speed * Time.deltaTime, rigidbody2D.velocity.y);
        }

        if (faceDirection != 0) {
            transform.localScale = new Vector3(faceDirection, 1f, 1f);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("jump");
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpForce * Time.deltaTime);
        }
    }
}