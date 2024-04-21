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
}
