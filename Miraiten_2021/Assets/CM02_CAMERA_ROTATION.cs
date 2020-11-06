using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CM02_CAMERA_ROTATION : MonoBehaviour
{
    bool startLerp;

    float currentLerpTime = 0;
    float maxLerpTime = 0.5f;

    Vector3 start;
    Vector3 end;

    public enum CAMERA_VIEW_ROTATION
    {
        CVR00_DEFAULT_ROTATION,
        CVR01_RIGHT_ROTATION,
        CVR02_LEFT_ROTATION,

        CVR03_NONE
    }

    CAMERA_VIEW_ROTATION currentView;
    CAMERA_VIEW_ROTATION nextRotation;

    private void Start()
    {
        currentView = CAMERA_VIEW_ROTATION.CVR00_DEFAULT_ROTATION;
        nextRotation = CAMERA_VIEW_ROTATION.CVR03_NONE;
        startLerp = true;
    }

    public void UpdateScript()
    {
        if (startLerp)
        {
            RotationLerp();
        }
    }

    private void RotationLerp()
    {
        float t = currentLerpTime / maxLerpTime;
        if (t > 1)
        {
            t = 1;
        }

        transform.eulerAngles = Vector3.Lerp(start, end, t);

        if (currentLerpTime > maxLerpTime)
        {
            currentLerpTime = 0;
            startLerp = false;
            currentView = nextRotation;
        }
        else
        {
            currentLerpTime += Time.deltaTime;
        }
    }

    public void SetMiddleViewOnDefault(CAMERA_VIEW_ROTATION checkCurrentView)
    {
        if (checkCurrentView != nextRotation)
        {
            nextRotation = CAMERA_VIEW_ROTATION.CVR00_DEFAULT_ROTATION;
            currentLerpTime = 0;
            start = transform.rotation.eulerAngles;
            end = new Vector3(0, 0, 0);

            startLerp = true;
        }
    }

    public void SetMiddleViewOnRight(CAMERA_VIEW_ROTATION checkCurrentView)
    {
        if (checkCurrentView != nextRotation)
        {
            nextRotation = CAMERA_VIEW_ROTATION.CVR01_RIGHT_ROTATION;
            currentLerpTime = 0;
            start = transform.rotation.eulerAngles;
            end = new Vector3(0, 35, 0);

            startLerp = true;
        }
       
    }

    public void SetMiddleViewOnLeft(CAMERA_VIEW_ROTATION checkCurrentView)
    {
        if (checkCurrentView != nextRotation)
        {
            nextRotation = CAMERA_VIEW_ROTATION.CVR02_LEFT_ROTATION;
            currentLerpTime = 0;
            start = transform.rotation.eulerAngles;
            end = new Vector3(0, -35, 0);

            startLerp = true;
        }
    }

    public void SetRightViewOnDefault(CAMERA_VIEW_ROTATION checkCurrentView)
    {
        if (checkCurrentView != nextRotation)
        {
            nextRotation = CAMERA_VIEW_ROTATION.CVR00_DEFAULT_ROTATION;
            currentLerpTime = 0;
            start = transform.rotation.eulerAngles;
            end = new Vector3(0, 24, 0);

            startLerp = true;
        }
    }

    public void SetRightViewOnRight(CAMERA_VIEW_ROTATION checkCurrentView)
    {
        if (checkCurrentView != nextRotation)
        {
            nextRotation = CAMERA_VIEW_ROTATION.CVR01_RIGHT_ROTATION;
            currentLerpTime = 0;
            start = transform.rotation.eulerAngles;
            end = new Vector3(0, 45, 0);

            startLerp = true;
        }
    }

    public void SetRightViewOnLeft(CAMERA_VIEW_ROTATION checkCurrentView)
    {
        if (checkCurrentView != nextRotation)
        {
            nextRotation = CAMERA_VIEW_ROTATION.CVR02_LEFT_ROTATION;
            currentLerpTime = 0;
            start = transform.rotation.eulerAngles;
            end = new Vector3(0, -8, 0);

            startLerp = true;
        }
    }

    public void SetLeftViewOnDefault(CAMERA_VIEW_ROTATION checkCurrentView)
    {
        if (checkCurrentView != nextRotation)
        {
            nextRotation = CAMERA_VIEW_ROTATION.CVR00_DEFAULT_ROTATION;
            currentLerpTime = 0;
            start = transform.rotation.eulerAngles;
            end = new Vector3(0, -24, 0);

            startLerp = true;
        }
    }

    public void SetLeftViewOnRight(CAMERA_VIEW_ROTATION checkCurrentView)
    {
        if (checkCurrentView != nextRotation)
        {
            nextRotation = CAMERA_VIEW_ROTATION.CVR01_RIGHT_ROTATION;
            currentLerpTime = 0;
            start = transform.rotation.eulerAngles;
            end = new Vector3(0, 10, 0);

            startLerp = true;
        }
    }

    public void SetLeftViewOnLeft(CAMERA_VIEW_ROTATION checkCurrentView)
    {
        if (checkCurrentView != nextRotation)
        {
            nextRotation = CAMERA_VIEW_ROTATION.CVR02_LEFT_ROTATION;
            currentLerpTime = 0;
            start = transform.rotation.eulerAngles;
            end = new Vector3(0, -50, 0);

            startLerp = true;
        }
    }
}
