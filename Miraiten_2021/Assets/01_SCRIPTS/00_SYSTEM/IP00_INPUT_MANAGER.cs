using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class IP00_INPUT_MANAGER : MonoBehaviour
{
    public static IP00_INPUT_MANAGER instance;

    INPUT_CONTROLER inputControler;

    #region Title Delegate
    public delegate void TitleActionTriggredDelagate();
    public delegate void TitleUpButtonTriggredDelegate();
    public delegate void TitleDownButtomTriggredDelegate();

    public TitleActionTriggredDelagate TitleActionTriggredEvent;
    public TitleUpButtonTriggredDelegate TitleUpButtonTriggredEvent;
    public TitleDownButtomTriggredDelegate TitleDownButtonTriggredEvent;
    #endregion

    #region Main Game Delegate  
    public delegate void MainGameActionTriggredDelegate();
    public delegate void MainGameUpButtonTriggredDelegate();
    public delegate void MainGameDownButtonTriggredDelegate();
    public delegate void MainGameRightButtonTriggredDelegate();
    public delegate void MainGameLeftButtonTriggredDelegate();

    public MainGameActionTriggredDelegate MainGameActionTriggredEvent;
    public MainGameUpButtonTriggredDelegate MainGameUpButtonTriggredEvent;
    public MainGameDownButtonTriggredDelegate MainGameDownButtonTriggredEvent;
    public MainGameRightButtonTriggredDelegate MainGameRightButtonTriggredEvent;
    public MainGameLeftButtonTriggredDelegate MainGameLeftButtonTriggredEvent;
    #endregion

    GS_GAME_SENCE sceneRecoreded;

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
            sceneRecoreded = GM00_GAME_MANAGER.instance.currentGameSence;
        }
    }

    private void OnEnable()
    {
        switch (sceneRecoreded)
        {
            case GS_GAME_SENCE.GS00_TITLE_SENCE:
                {
                    inputControler.TITLE_MENU.DECISON.performed += CheckTitleActionInput;
                    inputControler.TITLE_MENU.SELECTION.performed += CheckTitleSelectionInput;

                    inputControler.TITLE_MENU.DECISON.Enable();
                    inputControler.TITLE_MENU.SELECTION.Enable();
                }
                break;
            case GS_GAME_SENCE.GS01_MAIN_GAME:
                {
                    inputControler.MAIN_GAME.CAMERA_CONTROLE.performed += CheckMainGameActionInput;

                    
                }
                break;
            case GS_GAME_SENCE.GS02_GAME_RESULT:
                {

                }
                break;
        }
       
    }

    private void OnDisable()
    {
        switch (sceneRecoreded)
        {
            case GS_GAME_SENCE.GS00_TITLE_SENCE:
                {
                    inputControler.TITLE_MENU.DECISON.performed -= CheckTitleActionInput;
                    inputControler.TITLE_MENU.SELECTION.performed -= CheckTitleSelectionInput;

                    inputControler.TITLE_MENU.DECISON.Disable();
                    inputControler.TITLE_MENU.SELECTION.Disable();
                }
                break;
            case GS_GAME_SENCE.GS01_MAIN_GAME:
                {
  
                }
                break;
            case GS_GAME_SENCE.GS02_GAME_RESULT:
                {

                }
                break;
        }
        
    }


    #region Title Input
    private void CheckTitleActionInput(InputAction.CallbackContext inputContext)
    {
        TitleActionTriggredEvent?.Invoke();
    }

    private void CheckTitleSelectionInput(InputAction.CallbackContext inputContext)
    {
        float GetInput = inputContext.ReadValue<float>();

        if (GetInput == -1)
        {
            TitleUpButtonTriggredEvent?.Invoke();
        }
        else if (GetInput == 1)
        {
            TitleDownButtonTriggredEvent?.Invoke();
        }
    }
    #endregion

    #region Main Game 
    private void CheckMainGameActionInput(InputAction.CallbackContext inputContext)
    {
        Vector2 GetInput = inputContext.ReadValue<Vector2>();

        if (GetInput != null)
        {
            if (GetInput.x == -1)
            {
                MainGameLeftButtonTriggredEvent?.Invoke();
            }
            else if (GetInput.x == 1)
            {
                MainGameRightButtonTriggredEvent?.Invoke();
            }
            else if (GetInput.y == -1)
            {
                MainGameUpButtonTriggredEvent?.Invoke();
            }
            else if (GetInput.y == 1)
            {
                MainGameDownButtonTriggredEvent?.Invoke();
            }
        }
    }

    private void CheckMainGameSelectionInput(InputAction.CallbackContext inputContext)
    {
        MainGameActionTriggredEvent?.Invoke();
    }


    #endregion

}
