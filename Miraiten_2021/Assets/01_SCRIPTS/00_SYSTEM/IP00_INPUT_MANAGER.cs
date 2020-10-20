using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class IP00_INPUT_MANAGER : MonoBehaviour
{
    public static IP00_INPUT_MANAGER instance;

    INPUT_CONTROLER inputControler;

    public delegate void ActionTriggredDelagate();
    public delegate void UpButtonTriggredDelagate();
    public delegate void DownButtomTriggredDelagate();

    public ActionTriggredDelagate ActionTriggredEvent;
    public UpButtonTriggredDelagate UpButtonTriggredEvent;
    public DownButtomTriggredDelagate DownButtonTriggredEvent;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;

            inputControler = new INPUT_CONTROLER();
        }
    }

    private void OnEnable()
    {
        inputControler.TITLE_MENU.DECISON.performed += CheckActionInput;
        inputControler.TITLE_MENU.SELECTION.performed += CheckSelectionInput;

        inputControler.TITLE_MENU.DECISON.Enable();
        inputControler.TITLE_MENU.SELECTION.Enable();
    }

    private void OnDisable()
    {
        inputControler.TITLE_MENU.DECISON.performed -= CheckActionInput;
        inputControler.TITLE_MENU.SELECTION.performed -= CheckSelectionInput;

        inputControler.TITLE_MENU.DECISON.Disable();
        inputControler.TITLE_MENU.SELECTION.Disable();
    }

    private void CheckSelectionInput(InputAction.CallbackContext inputContext)
    {
        float GetInput = inputContext.ReadValue<float>();

        if (GetInput == -1)
        {
            UpButtonTriggredEvent?.Invoke();
        }
        else if (GetInput == 1)
        {
            DownButtonTriggredEvent?.Invoke();
        }
    }

    private void CheckActionInput(InputAction.CallbackContext inputContext)
    {
        ActionTriggredEvent?.Invoke();
    }

}
