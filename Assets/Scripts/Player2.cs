using UnityEngine;
using UnityEngine.InputSystem;

public class Player2 : MonoBehaviour
{
    private InputSystem inputSystem = null;
    private Rigidbody2D rb = null;
    private Vector2 direction = Vector2.zero;
    [SerializeField] private float speed = 0.0f;
    private float yBarriers = 0.0f;
    private float xPos = 0.0f;

    private void Awake()
    {
        inputSystem = new InputSystem();
        rb = GetComponent<Rigidbody2D>();
        yBarriers = 3.5f;
        speed = 600.0f;
        xPos = 7.0f;
    }

    private void OnEnable()
    {
        inputSystem.Enable();
        inputSystem.Player2.Movement.performed += MovementPerformed;
        inputSystem.Player2.Movement.canceled += MovementCanceled;
    }

    private void OnDisable()
    {
        inputSystem.Enable();
        inputSystem.Player2.Movement.performed -= MovementPerformed;
        inputSystem.Player2.Movement.canceled -= MovementCanceled;
    }

    private void FixedUpdate()
    {
        PlayerMovement();
        SetPlayerBarriers();
    }

    private void MovementPerformed(InputAction.CallbackContext value)
    {
        direction = value.ReadValue<Vector2>();
    }

    private void MovementCanceled(InputAction.CallbackContext obj)
    {
        direction = Vector2.zero;
    }

    private void PlayerMovement()
    {
        rb.velocity = speed * Time.deltaTime * direction;
    }

    private void SetPlayerBarriers()
    {
        // Stops player 2 paddle going out of the top of level
        if (transform.position.y > yBarriers)
        {
            direction = Vector2.zero;
            transform.position = new Vector2(xPos, yBarriers);
        }

        // Stops player 2 going out of the bottom of the level
        if (transform.position.y < -yBarriers)
        {
            direction = Vector2.zero;
            transform.position = new Vector2(xPos, -yBarriers);
        }
    }

    public void ResetPlayer2Position()
    {
        transform.position = new Vector2(xPos, 0.0f);
    }

    public float SetSpeed(float setSpeed)
    {
        return speed = setSpeed;
    }

    public Rigidbody2D SetRigidbody()
    {
        return rb;
    }
}
