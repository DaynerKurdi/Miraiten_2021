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

    public bool UpdateScript()
    {
        return cameraMovmentLerp.LerpProcess();
    }

    public void SetCameraPositionToMiddle()
    {
        cameraMovmentLerp.SetMovementMiddle();
    }

    public void SetCameraPositionToRight()
    {
        cameraMovmentLerp.SetMovmentRight();
    }

    public void SetCameraPositionLeft()
    {
        cameraMovmentLerp.SetMovmentLeft();
    }
    
}

