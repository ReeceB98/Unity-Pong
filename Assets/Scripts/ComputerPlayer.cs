using UnityEngine;

public class ComputerPlayer : MonoBehaviour
{
    private Rigidbody2D rb = null;
    private Vector2 computerMovement = Vector2.zero;
    [SerializeField] private float speed = 0.0f;
    [SerializeField] private GameObject ball;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void ComputerControl()
    {
        if (ball.transform.position.y > transform.position.y + 0.5f)
        {
            computerMovement = new Vector2(0.0f, 1.0f);
        }
        else if (ball.transform.position.y < transform.position.y - 0.5f)
        {
            computerMovement = new Vector2(0.0f, -1.0f);
        }
        else
        {
            computerMovement = new Vector2(0.0f, 0.0f);
        }

        if (ball.transform.position.x < 0.0f)
        {
            computerMovement = new Vector2(0.0f, 0.0f);
        }
    }

    private void Update()
    {
        ComputerControl();
    }

    private void FixedUpdate()
    {
        rb.velocity = computerMovement * Time.fixedDeltaTime * speed;
    }
}
