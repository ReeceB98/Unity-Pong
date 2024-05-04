using UnityEngine;

public class Ball : MonoBehaviour
{
    private ScoreManager scoreManager = null;
    private Player player1 = null;
    private Player2 player2 = null;

    [SerializeField] private float initialSpeed = 0.0f;
    [SerializeField] private float speedIncrease = 0.25f;
    private int hitCounter = 0;
    private Rigidbody2D rb;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        player1 = FindObjectOfType<Player>();
        player2 = FindObjectOfType<Player2>();
        rb = GetComponent<Rigidbody2D>();
        Invoke("StartBallLeft", 2.0f);
    }

    private void FixedUpdate()
    {
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, initialSpeed + (speedIncrease * hitCounter));
    }

    private void StartBallLeft()
    {
        rb.velocity = new Vector2(-1.0f, 0.0f) * (initialSpeed + speedIncrease * hitCounter);
    }
    public void StartBallRight()
    {
        rb.velocity = new Vector2(1.0f, 0.0f) * (initialSpeed + speedIncrease * hitCounter);
    }

    private void ResetBall(Collider2D other)
    {
        rb.velocity = new Vector2(0.0f, 0.0f);
        transform.position = new Vector2(0.0f, 0.0f);
        hitCounter = 0;

        if (other.gameObject.name == "Player1Wall")
        {
            Invoke("StartBallLeft", 2.0f);
        }

        if (other.gameObject.name == "Player2Wall")
        {
            Invoke("StartBallRight", 2.0f);
        }
    }

    public void StopBall()
    {
        rb.velocity = new Vector2(0.0f, 0.0f);
    }

    private void Bounce(Transform myObject)
    {
        hitCounter++;

        Vector2 ballPosition = transform.position;
        Vector2 playerPosition = myObject.position;

        float xDirection, yDirection;

        if (transform.position.x > 0.0f)
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
        if (collision.gameObject.name == "Player1" || collision.gameObject.name == "Player2" || collision.gameObject.name == "ComputerPlayer")
        {
            Bounce(collision.transform);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (transform.position.x > 0.0f)
        {
            scoreManager.UpdatePlayer1Score();
            ResetBall(other);
            player1.ResetPlayer1Position();
            player2.ResetPlayer2Position();
        }
        else
        {
            scoreManager.UpdatePlayer2Score();
            ResetBall(other);
            player2.ResetPlayer2Position();
            player1.ResetPlayer1Position();
        }
    }
}
