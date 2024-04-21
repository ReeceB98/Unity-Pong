using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player2 : MonoBehaviour
{
    private InputSystem inputSystem = null;
    private Rigidbody2D rb = null;
    private Vector2 direction = Vector2.zero;
    [SerializeField] private float speed = 0.0f;

    private void Awake()
    {
        inputSystem = new InputSystem();
        rb = GetComponent<Rigidbody2D>();
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
}
