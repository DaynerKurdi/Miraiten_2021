using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CT00_CAMERA_TRIGGER_MANAGER : MonoBehaviour
{
    public Transform rightObjectHolder;
    public Transform leftObjectHolder;

    [Space(10)]

    public Transform enterRight;
    public Transform enterLeft;

    [Space(10)]

    public Transform exitRight;
    public Transform exitLeft;

    [Space(10)]

    float currentLerpTime = 0;
    float maxLerpTime = 0.2f;

    [Space(10)]

    public CT05_UI_MOUSE_RECT middleViewRightTrigger;
    public CT05_UI_MOUSE_RECT middleViewLeftTrigger;

    [Space(10)]

    public CT05_UI_MOUSE_RECT rightRotationTrigger;
    public CT05_UI_MOUSE_RECT leftRotationTrigger;

    //[Space(10)]

    //public CT05_UI_MOUSE_RECT rightViewMiddleTrigger;
    //public CT05_UI_MOUSE_RECT rightViewLeftTrigger;

    //[Space(10)]

    //public CT05_UI_MOUSE_RECT leftViewMiddleTrigger;
    //public CT05_UI_MOUSE_RECT leftViewRightTrigger;

    private void Awake()
    {
        currentLerpTime = 0;

        rightObjectHolder.position = exitRight.position;
        leftObjectHolder.position = exitLeft.position;
    }

    public bool EnterRightObject()
    {
        float t = currentLerpTime / maxLerpTime;
        if (t > 1)
        {
            t = 1;
        }

        Vector3 result = Vector3.Lerp(exitRight.position, enterRight.position, t);
        rightObjectHolder.position = result;

        if (currentLerpTime >= maxLerpTime)
        {
            currentLerpTime = 0;

            return true;
        }
        else
        {
            currentLerpTime += Time.deltaTime;
            return false;
        }
    }

    public bool ExitRightObject()
    {
        float t = currentLerpTime / maxLerpTime;
        if (t > 1)
        {
            t = 1;
        }

        Vector3 result = Vector3.Lerp(enterRight.position, exitRight.position, t);
        rightObjectHolder.position = result;

        if (currentLerpTime >= maxLerpTime)
        {
            currentLerpTime = 0;

            return true;
        }
        else
        {
            currentLerpTime += Time.deltaTime;
            return false;
        }
    }

    public bool EnterLeftObject()
    {
        float t = currentLerpTime / maxLerpTime;
        if (t > 1)
        {
            t = 1;
        }

        Vector3 result = Vector3.Lerp(exitLeft.position, enterLeft.position, t);
        leftObjectHolder.position = result;

        if (currentLerpTime >= maxLerpTime)
        {
            currentLerpTime = 0;

            return true;
        }
        else
        {
            currentLerpTime += Time.deltaTime;
            return false;
        }
    }

    public bool ExitLeftObject()
    {
        float t = currentLerpTime / maxLerpTime;
        if (t > 1)
        {
            t = 1;
        }

        Vector3 result = Vector3.Lerp(enterLeft.position, exitLeft.position, t);
        leftObjectHolder.position = result;

        if (currentLerpTime >= maxLerpTime)
        {
            currentLerpTime = 0;

            return true;
        }
        else
        {
            currentLerpTime += Time.deltaTime;
            return false;
        }
    }

    public void CheckRotationTrigger(out bool rightTrigger, out bool leftTrigger)
    {
        rightTrigger = rightRotationTrigger.GetMouseOnTrigger();
        leftTrigger = leftRotationTrigger.GetMouseOnTrigger();
    }

    public void CheckMiddleViewTrigger(out bool rightTrigger, out bool leftTrigger)
    {
        rightTrigger = middleViewRightTrigger.GetMouseOnTrigger();
        leftTrigger = middleViewLeftTrigger.GetMouseOnTrigger();
    }

    public void CheckRightViewTrigger(out bool middleTrigger, out bool leftTrigger)
    {
        middleTrigger = false;
        leftTrigger = false;

        //middleTrigger = middleViewRightTrigger.GetMouseOnTrigger();
        //leftTrigger = leftViewRightTrigger.GetMouseOnTrigger();
    }

    public void CheckLeftViewTrigger(out bool middleTrigger, out bool rightTrigger)
    {
        middleTrigger = false;
        rightTrigger = false;

    //    middleTrigger = middleViewLeftTrigger.GetMouseOnTrigger();
    //    rightTrigger = rightViewLeftTrigger.GetMouseOnTrigger();
    }

    public bool GetMiddleViewRightClickFlag()
    {
        return middleViewRightTrigger.GetMouseClickTrigger();
    }

    public bool GetMiddleViewLeftClickFlag()
    {
        return middleViewLeftTrigger.GetMouseClickTrigger();
    }

    public void SetMiddleViewRightFlag(bool flag)
    {
        middleViewRightTrigger.SetMouseClickFlag(flag);
    }

    public void SetMiddleViewLeftFlag(bool flag)
    {
        middleViewLeftTrigger.SetMouseClickFlag(flag);
    }
    
}
