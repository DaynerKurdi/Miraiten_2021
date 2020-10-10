using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class inputTester : MonoBehaviour
{
    [SerializeField]
    InputTest controls;

    private void Awake()
    {
        controls = new InputTest();
    }

    private void OnEnable()
    {
        controls.test.action.performed += move;
        controls.test.action.Enable();
    }

    private void OnDisable()
    {
        controls.test.action.performed -= move;
        controls.test.action.Disable();
    }

    private void move(InputAction.CallbackContext obj)
    {
        Debug.Log("fire");
    }
}
