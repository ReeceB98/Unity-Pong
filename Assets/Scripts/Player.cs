using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private InputSystem inputSystem = null;
    private Rigidbody2D rb = null;
    private Vector2 direction = Vector2.zero;
    [SerializeField] private float speed = 0.0f;

    private void Awake()
    {
        inputSystem = new InputSystem();
        rb = GetComponent<Rigidbody2D>();
        speed = 300.0f;
    }

    private void OnEnable()
    {
        inputSystem.Enable();
        inputSystem.Player.Movement.performed += MovementPerformed;
        inputSystem.Player.Movement.canceled += MovementCancelled;
    }

    private void OnDisable()
    {
        inputSystem.Disable();
        inputSystem.Player.Movement.performed -= MovementPerformed;
        inputSystem.Player.Movement.canceled -= MovementCancelled;
    }

    private void FixedUpdate()
    {
        rb.velocity = speed * Time.deltaTime * direction;
        Debug.Log($"Velocity: {rb.velocity}");
    }

    private void MovementPerformed(InputAction.CallbackContext value)
    {
        direction = value.ReadValue<Vector2>();
    }

    private void MovementCancelled(InputAction.CallbackContext value)
    {
        direction = Vector2.zero;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
