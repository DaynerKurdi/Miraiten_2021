using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CM00_CAMERA_MAIN : MonoBehaviour
{
    CM01_CAMERA_LERP cameraMovmentLerp;
    CM02_CAMERA_ROTATION cameraViewRotation;

    private void Awake()
    {
        cameraMovmentLerp = GetComponent<CM01_CAMERA_LERP>();
        cameraViewRotation = GetComponent<CM02_CAMERA_ROTATION>();
    }

    public void UpdateScript()
    {
       // cameraViewRotation.UpdateScript();
    }

    public void SetCameraViewToDefult(SM00_SENCE_MANAGER.CAMERA_VIEW_STATE currentView )
    {
        switch (currentView)
        {
            case SM00_SENCE_MANAGER.CAMERA_VIEW_STATE.CV00_MIDDLE_VIEW:
                cameraViewRotation.SetMiddleViewOnDefault(CM02_CAMERA_ROTATION.CAMERA_VIEW_ROTATION.CVR00_DEFAULT_ROTATION);
                break;
            case SM00_SENCE_MANAGER.CAMERA_VIEW_STATE.CV01_RIGHT_VIEW:
                cameraViewRotation.SetRightViewOnDefault(CM02_CAMERA_ROTATION.CAMERA_VIEW_ROTATION.CVR01_RIGHT_ROTATION);
                break;
            case SM00_SENCE_MANAGER.CAMERA_VIEW_STATE.CV02_LEFT_VIEW:
                cameraViewRotation.SetLeftViewOnDefault(CM02_CAMERA_ROTATION.CAMERA_VIEW_ROTATION.CVR02_LEFT_ROTATION);
                break;
        }
    }

    public void SetCameraViewToRight(SM00_SENCE_MANAGER.CAMERA_VIEW_STATE currentView)
    {
        switch (currentView)
        {
            case SM00_SENCE_MANAGER.CAMERA_VIEW_STATE.CV00_MIDDLE_VIEW:
                cameraViewRotation.SetRightViewOnDefault(CM02_CAMERA_ROTATION.CAMERA_VIEW_ROTATION.CVR00_DEFAULT_ROTATION);
                break;
            case SM00_SENCE_MANAGER.CAMERA_VIEW_STATE.CV01_RIGHT_VIEW:
                cameraViewRotation.SetRightViewOnRight(CM02_CAMERA_ROTATION.CAMERA_VIEW_ROTATION.CVR01_RIGHT_ROTATION);
                break;
            case SM00_SENCE_MANAGER.CAMERA_VIEW_STATE.CV02_LEFT_VIEW:
                cameraViewRotation.SetRightViewOnLeft(CM02_CAMERA_ROTATION.CAMERA_VIEW_ROTATION.CVR02_LEFT_ROTATION);
                break;
        }
    }

    public void SetCameraViewToLeft(SM00_SENCE_MANAGER.CAMERA_VIEW_STATE currentView)
    {
        switch (currentView)
        {
            case SM00_SENCE_MANAGER.CAMERA_VIEW_STATE.CV00_MIDDLE_VIEW:
                cameraViewRotation.SetLeftViewOnDefault(CM02_CAMERA_ROTATION.CAMERA_VIEW_ROTATION.CVR00_DEFAULT_ROTATION);
                break;
            case SM00_SENCE_MANAGER.CAMERA_VIEW_STATE.CV01_RIGHT_VIEW:
                cameraViewRotation.SetLeftViewOnRight(CM02_CAMERA_ROTATION.CAMERA_VIEW_ROTATION.CVR01_RIGHT_ROTATION);
                break;
            case SM00_SENCE_MANAGER.CAMERA_VIEW_STATE.CV02_LEFT_VIEW:
                cameraViewRotation.SetLeftViewOnLeft(CM02_CAMERA_ROTATION.CAMERA_VIEW_ROTATION.CVR02_LEFT_ROTATION);
                break;
        }
    }
}

