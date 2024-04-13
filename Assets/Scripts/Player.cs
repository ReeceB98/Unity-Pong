using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private InputSystem inputSystem = null;

    private void Awake()
    {
        inputSystem = new InputSystem();    
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
