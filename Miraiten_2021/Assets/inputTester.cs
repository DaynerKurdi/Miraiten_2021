using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class inputTester : MonoBehaviour
{
    [SerializeField]
    InputTest controls;

    public InputAction test;

    private void Awake()
    {
        controls = new InputTest();
    }

    private void OnEnable()
    {
      //  controls.test.action.performed += move;
        controls.Keybord.MenuControlOne.performed += move;

        controls.Keybord.MenuControlOne.Enable();
      
    }

    private void OnDisable()
    {
        controls.Keybord.MenuControlOne.performed -= move;

        controls.Keybord.MenuControlOne.Disable();
    }

    private void move(InputAction.CallbackContext obj)
    {
      var input =  obj.ReadValue<Vector2>();

        Debug.Log("fire " + input);
    }
}

//https://docs.unity3d.com/Packages/com.unity.inputsystem@0.1/api/UnityEngine.Experimental.Input.InputActionAsset.html


//using UnityEngine;
//using UnityEngine.InputSystem;
 
//public class Player : MonoBehaviour
//{
//    public InputActionAsset playerControls;

//    private InputAction movement;
//    private InputAction fire;

//    private void Awake()
//    {
//        var gameplayActionMap = playerControls.FindActionMap("Gameplay");

//        movement = gameplayActionMap.FindAction("Movement");
//        movement.performed += OnMovementChanged;
//        movement.canceled += OnMovementChanged;
//        movement.Enable();

//        fire = gameplayActionMap.GetAction("Fire");
//        fire.performed += OnFireChanged;
//        fire.Enable();
//    }

//    private void OnMovementChanged(InputAction.CallbackContext context)
//    {
//        var direction = context.ReadValue<Vector2>();

//        // Code that moves the player based on the direction
//    }

//    private void OnFireChanged(InputAction.CallbackContext context)
//    {
//        // Code that fires a projectile
//    }
//}
