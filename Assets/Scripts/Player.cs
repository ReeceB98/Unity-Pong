using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
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
        speed = 600.0f;
        yBarriers = 3.5f;
        xPos = 7.0f;
    }

    private void OnEnable()
    {
        inputSystem.Enable();
        inputSystem.Player1.Movement.performed += MovementPerformed;
        inputSystem.Player1.Movement.canceled += MovementCancelled;
    }

    private void OnDisable()
    {
        inputSystem.Disable();
        inputSystem.Player1.Movement.performed -= MovementPerformed;
        inputSystem.Player1.Movement.canceled -= MovementCancelled;
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

    private void MovementCancelled(InputAction.CallbackContext value)
    {
        direction = Vector2.zero;
    }

    private void PlayerMovement()
    {
        rb.velocity = speed * Time.deltaTime * direction;
    }

    private void SetPlayerBarriers()
    {
        // Stops player 1 paddle going out of the top of level
        if (transform.position.y > yBarriers)
        {
            direction = Vector2.zero;
            transform.position = new Vector2(-xPos, yBarriers);
        }

        // Stops player 1 going out of the bottom of the level
        if (transform.position.y < -yBarriers)
        {
            direction = Vector2.zero;
            transform.position = new Vector2(-xPos, -yBarriers);
        }
    }

    public void ResetPlayer1Position()
    {
        transform.position = new Vector2(-xPos, 0.0f);
    }
}
