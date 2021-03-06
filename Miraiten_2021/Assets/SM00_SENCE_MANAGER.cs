﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SM00_SENCE_MANAGER : MonoBehaviour
{
    public CM00_CAMERA_MAIN cameraMainManager;
    public CT00_CAMERA_TRIGGER_MANAGER cameraTriggerManager;

    bool mouseOnRight = false;
    bool mouseOnLeft = false;
    
    bool mouseOnRightViewLeftSide = false;
    bool mouseOnLeftViewRightSide = false;

    bool enterLerpIsDone = false;
    bool exitLerpIsDone = false;

    public enum CAMERA_VIEW_STATE
    {
        CV00_MIDDLE_VIEW,
        CV01_RIGHT_VIEW,
        CV02_LEFT_VIEW,

        CV03_LERP_PROCESS
    }

    public enum CAMERA_VIEW_LERP_PROCESS
    {
        CVLP00_DO_MIDDLE_VIEW_R,
        CVLP01_DO_MIDDLE_VIEW_L,

        CVLP02_DO_RIGHT_VIEW_T,
        CVLP03_DO_RIGHT_VIEW_B,

        CVLP04_DO_LEFT_VIEW_T,
        CVLP05_DO_LEFT_VIEW_B
    }

    public CAMERA_VIEW_STATE cameraViewState;
   
    public CAMERA_VIEW_STATE nextViewState;

    public CAMERA_VIEW_LERP_PROCESS lerpProcess;

    private void Awake()
    {
        cameraViewState = CAMERA_VIEW_STATE.CV00_MIDDLE_VIEW;

        mouseOnRight = false;
        mouseOnLeft = false;

        mouseOnRightViewLeftSide = false;
        mouseOnLeftViewRightSide = false;

        enterLerpIsDone = false;
        exitLerpIsDone = false;
    }

    private void Update()
    {
        switch (cameraViewState)
        {
            case CAMERA_VIEW_STATE.CV00_MIDDLE_VIEW:
                {
                    CheckMiddleView();
                    //cameraMainManager.UpdateScript();
                }
                break;
            case CAMERA_VIEW_STATE.CV01_RIGHT_VIEW:
                {
                    CheckRightView();
                }
                break;
            case CAMERA_VIEW_STATE.CV02_LEFT_VIEW:
                {
                    checkLeftView();
                }
                break;
            case CAMERA_VIEW_STATE.CV03_LERP_PROCESS:
                {
                    LerpProcessManager();
                }
                break;
        }
    }
    private void CheckMiddleView()
    {
        bool checkRight = false;
        bool checkLeft = false;

        cameraTriggerManager.CheckMiddleViewEnterTrigger(out checkRight, out checkLeft);

        CheckMiddleRight(ref checkRight);
        CheckMiddleLeft(ref checkLeft);
    }

    private void CheckRightView()
    {
        bool checkBody = false;

        cameraTriggerManager.CheckRightViewBodyEnterTrigger(out checkBody);

        CheckRightViewBody(ref checkBody);
    }

    private void checkLeftView()
    {
        bool checkBody = false;

        cameraTriggerManager.CheckLeftViewBodyEnterTrigger(out checkBody);

        CheckLeftViewBody(ref checkBody);
    }

    private void CheckMiddleRight(ref bool checkRight)
    {
        if (checkRight)
        {
            // If mouse on right trigger area and if the the object is not yet active  
            if (!enterLerpIsDone)
            {
                enterLerpIsDone = cameraTriggerManager.EnterObject(CT00_CAMERA_TRIGGER_MANAGER.UI_POSITION_OBJECT_BUTTON.UPOB00_MIDDLE_VIEW_RIGHT);
                if (enterLerpIsDone)
                {
                    exitLerpIsDone = false;
                    mouseOnRight = true;
                }
            }
            // If mouse on right trigger area and press the active button 
            else if (mouseOnRight)
            {
                if (cameraTriggerManager.GetMiddleViewRightClickFlag())
                {
                    cameraMainManager.SetCameraPositionToRight();
                    cameraTriggerManager.SetMiddleViewRightMouseClickFlag(false);

                    nextViewState = CAMERA_VIEW_STATE.CV01_RIGHT_VIEW;
                    cameraViewState = CAMERA_VIEW_STATE.CV03_LERP_PROCESS;
                    lerpProcess = CAMERA_VIEW_LERP_PROCESS.CVLP00_DO_MIDDLE_VIEW_R;
                }
            }

        }
        else if (mouseOnRight)
        {
            if (!exitLerpIsDone)
            {
                exitLerpIsDone = cameraTriggerManager.ExitObject(CT00_CAMERA_TRIGGER_MANAGER.UI_POSITION_OBJECT_BUTTON.UPOB00_MIDDLE_VIEW_RIGHT);
                if (exitLerpIsDone)
                {
                    enterLerpIsDone = false;
                    mouseOnRight = false;
                }
            }
        }
    }

    private void CheckMiddleLeft(ref bool checkLeft)
    {
        if (checkLeft)
        {
            // If mouse on Left trigger area and if the the object is not yet active  
            if (!enterLerpIsDone)
            {
                enterLerpIsDone = cameraTriggerManager.EnterObject(CT00_CAMERA_TRIGGER_MANAGER.UI_POSITION_OBJECT_BUTTON.UPOB01_MIDDLE_VIEW_LEFT);
                if (enterLerpIsDone)
                {
                    exitLerpIsDone = false;
                    mouseOnLeft = true;
                }
            }
            // If mouse on Left trigger area and press the active button 
            else 
            {
                if (cameraTriggerManager.GetMiddleViewLeftClickFlag())
                {
                    cameraMainManager.SetCameraPositionLeft();
                    cameraTriggerManager.SetMiddleViewLeftMouseClickFlag(false);

                    nextViewState = CAMERA_VIEW_STATE.CV02_LEFT_VIEW;
                    cameraViewState = CAMERA_VIEW_STATE.CV03_LERP_PROCESS;
                    lerpProcess = CAMERA_VIEW_LERP_PROCESS.CVLP01_DO_MIDDLE_VIEW_L;
                }
            }
        }
        else if (mouseOnLeft)
        {
            if (!exitLerpIsDone)
            {
                exitLerpIsDone = cameraTriggerManager.ExitObject(CT00_CAMERA_TRIGGER_MANAGER.UI_POSITION_OBJECT_BUTTON.UPOB01_MIDDLE_VIEW_LEFT);
                if (exitLerpIsDone)
                {
                    enterLerpIsDone = false;
                    mouseOnLeft = false;
                }
            }
        }
    }

    void CheckRightViewBody(ref bool trigger)
    {
        if (trigger)
        {
            if (!enterLerpIsDone)
            {
                enterLerpIsDone = cameraTriggerManager.EnterObject(CT00_CAMERA_TRIGGER_MANAGER.UI_POSITION_OBJECT_BUTTON.UPOB03_RIGHT_VIEW_LEFT);

                if (enterLerpIsDone)
                {
                    exitLerpIsDone = false;
                    mouseOnRightViewLeftSide = true;
                }
            }
            else 
            {
                if (cameraTriggerManager.GetRightViewTopClickFlag())
                {
                    cameraMainManager.SetCameraPositionToMiddle();
                    cameraTriggerManager.SetRightViewTopMouseClickFlag(false);

                    nextViewState = CAMERA_VIEW_STATE.CV00_MIDDLE_VIEW;
                    cameraViewState = CAMERA_VIEW_STATE.CV03_LERP_PROCESS;
                    lerpProcess = CAMERA_VIEW_LERP_PROCESS.CVLP02_DO_RIGHT_VIEW_T;
                }
                else if (cameraTriggerManager.GetRightViewBottomClickFlag())
                {
                    cameraMainManager.SetCameraPositionLeft();
                    cameraTriggerManager.SetRightViewBottomMouseClickFlag(false);

                    nextViewState = CAMERA_VIEW_STATE.CV02_LEFT_VIEW;
                    cameraViewState = CAMERA_VIEW_STATE.CV03_LERP_PROCESS;
                    lerpProcess = CAMERA_VIEW_LERP_PROCESS.CVLP03_DO_RIGHT_VIEW_B;
                }
               
            }
            
        }
        else if (mouseOnRightViewLeftSide)
        {
            if (!exitLerpIsDone)
            {
                exitLerpIsDone = cameraTriggerManager.ExitObject(CT00_CAMERA_TRIGGER_MANAGER.UI_POSITION_OBJECT_BUTTON.UPOB03_RIGHT_VIEW_LEFT);

                if (exitLerpIsDone)
                {
                    enterLerpIsDone = false;
                    mouseOnRightViewLeftSide = false;
                }
            }
            
        }
    }

    private void CheckLeftViewBody(ref bool trigger)
    {
        if (trigger)
        {
            if (!enterLerpIsDone)
            {
                enterLerpIsDone = cameraTriggerManager.EnterObject(CT00_CAMERA_TRIGGER_MANAGER.UI_POSITION_OBJECT_BUTTON.UPOB04_LEFT_VIEW_RIGHT);

                if (enterLerpIsDone)
                {
                    exitLerpIsDone = false;
                    mouseOnLeftViewRightSide = true;
                }
            }

            else
            {
                if (cameraTriggerManager.GetLeftViewTopClickFlag())
                {
                    cameraMainManager.SetCameraPositionToMiddle();
                    cameraTriggerManager.SetLeftViewTopMouseClickFlag(false);

                    nextViewState = CAMERA_VIEW_STATE.CV00_MIDDLE_VIEW;
                    cameraViewState = CAMERA_VIEW_STATE.CV03_LERP_PROCESS;
                    lerpProcess = CAMERA_VIEW_LERP_PROCESS.CVLP04_DO_LEFT_VIEW_T;
                }
                else if (cameraTriggerManager.GetLeftViewBottomClickFlag())
                {
                    cameraMainManager.SetCameraPositionToRight();
                    cameraTriggerManager.SetLeftViewBottomMouseClickFlag(false);

                    nextViewState = CAMERA_VIEW_STATE.CV01_RIGHT_VIEW;
                    cameraViewState = CAMERA_VIEW_STATE.CV03_LERP_PROCESS;
                    lerpProcess = CAMERA_VIEW_LERP_PROCESS.CVLP05_DO_LEFT_VIEW_B;
                }
            }
        }
        else if (mouseOnLeftViewRightSide)
        {
            if (!exitLerpIsDone)
            {
                exitLerpIsDone = cameraTriggerManager.ExitObject(CT00_CAMERA_TRIGGER_MANAGER.UI_POSITION_OBJECT_BUTTON.UPOB04_LEFT_VIEW_RIGHT);

                if (exitLerpIsDone)
                {
                    enterLerpIsDone = false;
                    mouseOnLeftViewRightSide = false;
                }
               
            }
        }
    }


    void LerpProcessManager()
    {
        switch (lerpProcess)
        {
            case CAMERA_VIEW_LERP_PROCESS.CVLP00_DO_MIDDLE_VIEW_R:
                {
                    if (cameraTriggerManager.ExitObject(CT00_CAMERA_TRIGGER_MANAGER.UI_POSITION_OBJECT_BUTTON.UPOB00_MIDDLE_VIEW_RIGHT))
                    {
                        cameraTriggerManager.SetMiddleViewRightEnterFlag(false);
                        cameraTriggerManager.SetMiddleViewObjectsActiveFlag(false);

                        cameraTriggerManager.SetRightViewObjectActiveFlag(true);

                        mouseOnRight = false;
                        enterLerpIsDone = false;
                    }
                }
                break;
            case CAMERA_VIEW_LERP_PROCESS.CVLP01_DO_MIDDLE_VIEW_L:
                {
                    if (cameraTriggerManager.ExitObject(CT00_CAMERA_TRIGGER_MANAGER.UI_POSITION_OBJECT_BUTTON.UPOB01_MIDDLE_VIEW_LEFT))
                    {
                        cameraTriggerManager.SetMiddleViewLeftEnterFlag(false);
                        cameraTriggerManager.SetMiddleViewObjectsActiveFlag(false);

                        cameraTriggerManager.SetLeftViewObjectActiveFlag(true);

                        mouseOnLeft = false;
                        enterLerpIsDone = false;
                    }
                }
                break;
            case CAMERA_VIEW_LERP_PROCESS.CVLP02_DO_RIGHT_VIEW_T:
                {
                    if (cameraTriggerManager.ExitObject(CT00_CAMERA_TRIGGER_MANAGER.UI_POSITION_OBJECT_BUTTON.UPOB03_RIGHT_VIEW_LEFT))
                    {
                        cameraTriggerManager.SetRightViewEnterFlag(false);
                        cameraTriggerManager.SetRightViewObjectActiveFlag(false);

                        cameraTriggerManager.SetMiddleViewObjectsActiveFlag(true);

                        mouseOnRightViewLeftSide = false;
                        enterLerpIsDone = false;
                    }
                }
                break;
            case CAMERA_VIEW_LERP_PROCESS.CVLP03_DO_RIGHT_VIEW_B:
                {
                    if (cameraTriggerManager.ExitObject(CT00_CAMERA_TRIGGER_MANAGER.UI_POSITION_OBJECT_BUTTON.UPOB03_RIGHT_VIEW_LEFT))
                    {
                        cameraTriggerManager.SetRightViewEnterFlag(false);
                        cameraTriggerManager.SetRightViewObjectActiveFlag(false);

                        cameraTriggerManager.SetLeftViewObjectActiveFlag(true);

                        mouseOnRightViewLeftSide = false;
                        enterLerpIsDone = false;
                    }
                }
                break;
            case CAMERA_VIEW_LERP_PROCESS.CVLP04_DO_LEFT_VIEW_T:
                {
                    if (cameraTriggerManager.ExitObject(CT00_CAMERA_TRIGGER_MANAGER.UI_POSITION_OBJECT_BUTTON.UPOB04_LEFT_VIEW_RIGHT))
                    {
                        cameraTriggerManager.SetLeftViewEnterFlag(false);
                        cameraTriggerManager.SetLeftViewObjectActiveFlag(false);

                        cameraTriggerManager.SetMiddleViewObjectsActiveFlag(true);

                        mouseOnLeftViewRightSide = false;
                        enterLerpIsDone = false;
                    }
                }
                break;
            case CAMERA_VIEW_LERP_PROCESS.CVLP05_DO_LEFT_VIEW_B:
                {
                    if (cameraTriggerManager.ExitObject(CT00_CAMERA_TRIGGER_MANAGER.UI_POSITION_OBJECT_BUTTON.UPOB04_LEFT_VIEW_RIGHT))
                    {
                        cameraTriggerManager.SetLeftViewEnterFlag(false);
                        cameraTriggerManager.SetLeftViewObjectActiveFlag(false);

                        cameraTriggerManager.SetRightViewObjectActiveFlag(true);

                        mouseOnLeftViewRightSide = false;
                        enterLerpIsDone = false;
                    }
                }
                break;
        }

        if (cameraMainManager.UpdateScript())
        {
            cameraViewState = nextViewState;
        }
    }
}


