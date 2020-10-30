using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SM00_SENCE_MANAGER : MonoBehaviour
{
    public CM00_CAMERA_MAIN cameraMainManager;
    public CT00_CAMERA_TRIGGER_MANAGER cameraTriggerManager;

    bool mouseOnRight = false;
    bool mouseOnLeft = false;

    bool mouseOnRightRotation = false;
    bool mouseOnLeftRotation = false;

    bool enterLerpIsDone = false;
    bool exitLerpIsDone = false;

    public enum CAMERA_VIEW_STATE
    {
        CV00_MIDDLE_VIEW,
        CV01_RIGHT_VIEW,
        CV02_LEFT_VIEW,

        CV03_LERP_PROCESS
    }

    public CAMERA_VIEW_STATE cameraViewState;

    private void Awake()
    {
        cameraViewState = CAMERA_VIEW_STATE.CV00_MIDDLE_VIEW;

        mouseOnRight = false;
        mouseOnLeft = false;
        enterLerpIsDone = false;
        exitLerpIsDone = false;
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        switch (cameraViewState)
        {
            case CAMERA_VIEW_STATE.CV00_MIDDLE_VIEW:
                {
                    CheckRotationTrigger();
                    CheckMiddleView();
                    
                }
                break;
            case CAMERA_VIEW_STATE.CV01_RIGHT_VIEW:
                {

                }
                break;
            case CAMERA_VIEW_STATE.CV02_LEFT_VIEW:
                {

                }
                break;
            case CAMERA_VIEW_STATE.CV03_LERP_PROCESS:
                {

                }
                break;
        }
    }

    private void CheckMiddleView()
    {
        bool checkRight = false;
        bool checkLeft = false;

        cameraTriggerManager.CheckMiddleViewTrigger(out checkRight, out checkLeft);

        CheckMiddleRight(ref checkRight);
        CheckMiddleLeft(ref checkLeft);
    }

    private void CheckRotationTrigger()
    {
        bool checkRight = false;
        bool checkLeft = false;

        cameraTriggerManager.CheckRotationTrigger(out checkRight, out checkLeft);

        if (checkRight)
        {
            cameraMainManager.SetCameraViewToRight(cameraViewState);
        }

        if (checkLeft)
        {
            cameraMainManager.SetCameraViewToLeft(cameraViewState);
        }
    }



    private void CheckMiddleRight(ref bool checkRight)
    {
        if (checkRight)
        {
            // If mouse on right trigger area and if the the object is not yet active  
            if (!enterLerpIsDone)
            {
                enterLerpIsDone = cameraTriggerManager.EnterRightObject();
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
                    cameraTriggerManager.SetMiddleViewRightFlag(false);
                }
            }

        }
        else if (mouseOnRight)
        {
            if (!exitLerpIsDone)
            {
                exitLerpIsDone = cameraTriggerManager.ExitRightObject();
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
                enterLerpIsDone = cameraTriggerManager.EnterLeftObject();
                if (enterLerpIsDone)
                {
                    exitLerpIsDone = false;
                    mouseOnLeft = true;
                }
            }
            // If mouse on Left trigger area and press the active button 
            else if (checkLeft)
            {
                if (cameraTriggerManager.GetMiddleViewLeftClickFlag())
                {
                    cameraTriggerManager.SetMiddleViewLeftFlag(false);
                }
            }

        }
        else if (mouseOnLeft)
        {
            if (!exitLerpIsDone)
            {
                exitLerpIsDone = cameraTriggerManager.ExitLeftObject();
                if (exitLerpIsDone)
                {
                    enterLerpIsDone = false;
                    mouseOnLeft = false;
                }
            }
        }
    }


}


