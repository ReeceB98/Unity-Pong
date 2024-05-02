using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float initialSpeed = 0.0f;
    [SerializeField] private float speedIncrease = 0.25f;
    private int hitCounter = 0;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Invoke("StartBall", 2.0f);
    }

    private void FixedUpdate()
    {
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, initialSpeed + (speedIncrease * hitCounter));
    }

    private void StartBall()
    {
        rb.velocity = new Vector2(-1.0f, 0.0f) * (initialSpeed + speedIncrease * hitCounter);
    }

    private void ResetBall()
    {
        rb.velocity = new Vector2(0.0f, 0.0f);
        transform.position = new Vector2(0.0f, 0.0f);
        hitCounter = 0;
        Invoke("StartBall", 2.0f);
    }

    private void Bounce(Transform myObject)
    {
        hitCounter++;

        Vector2 ballPosition = transform.position;
        Vector2 playerPosition = myObject.position;

        float xDirection, yDirection;

        if (transform.position.x > 0)
        {
            xDirection = -1.0f;
        }
        else
        {
            xDirection = 1.0f;
        }

        // Finds the position of where the ball hits the paddle.
        yDirection = (ballPosition.y - playerPosition.y) / myObject.GetComponent<Collider2D>().bounds.size.y;
        
        if (yDirection == 0.0f)
        {
            yDirection = 0.25f;
        }

        rb.velocity = new Vector2(xDirection, yDirection) * (initialSpeed + (speedIncrease * hitCounter));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player1" || collision.gameObject.name == "Player2")
        {
            Bounce(collision.transform);
        }
    }
}