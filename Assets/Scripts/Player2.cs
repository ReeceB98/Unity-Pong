using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player2 : Player
{
    private InputSystem inputSystem = null;
    private Rigidbody2D rb = null;
    private InputAction.CallbackContext value;
    private void Awake()
    {
        inputSystem = new InputSystem();
        rb = GetComponent<Rigidbody2D>();
        //MovementPerformed(value);
    }
}
