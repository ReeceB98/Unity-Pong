using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private InputSystem inputSystem = null;
    private Rigidbody2D rb = null;

    private void Awake()
    {
        inputSystem = new InputSystem();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        inputSystem.Enable();
        inputSystem.Player.Movement.performed += MovementPerformed;
    }

    private void OnDisable()
    {
        inputSystem.Disable();
        inputSystem.Player.Movement.performed -= MovementPerformed;
    }

    private void MovementPerformed(InputAction.CallbackContext value)
    {
        //Debug.Log("Movement Performed");
        Debug.Log(value.ReadValue<Vector2>());
        Vector2 vector = value.ReadValue<Vector2>();
        float speed = 100.0f;
        Vector2 direction = new Vector2(vector.x * speed * Time.deltaTime, vector.y * speed * Time.deltaTime);
        rb.AddForce(direction, ForceMode2D.Impulse);
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
