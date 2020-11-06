using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CT00_CAMERA_TRIGGER_MANAGER : MonoBehaviour
{
    public Transform rightObjectTypeOne;
    public Transform rightObjectTypeTwo;
    public Transform leftObjectTypeOne;
    public Transform leftObjectTypeTwo;

    [Space(10)]

    public Transform rightObjectUiHolderOne;
    public Transform rightObjectUiHolderTwo;
    public Transform leftObjectUiHolderOne;
    public Transform leftObjectUiHolderTwo;

    [Space(10)]
    [SerializeField]
    Transform enterRight;
    [SerializeField]
    Transform enterLeft;

    [Space(10)]
    [SerializeField]
    Transform exitRight;
    [SerializeField]
    Transform exitLeft;

    [Space(10)]
    [SerializeField]
    float currentLerpTime = 0;
    [SerializeField]
    float maxLerpTime = 0.2f;

    [Space(10)]

    public CT05_UI_MOUSE_RECT middleViewRightTrigger;
    public CT05_UI_MOUSE_RECT middleViewLeftTrigger;

    [Space(10)]

    public CT05_UI_MOUSE_RECT rightViewBodyTrigger;
    public CT05_UI_MOUSE_RECT rightViewTopTrigger;
    public CT05_UI_MOUSE_RECT rightViewBottomTrigger;

    [Space(10)]

    public CT05_UI_MOUSE_RECT leftViewBodyTrigger;
    public CT05_UI_MOUSE_RECT leftViewTopTrigger;
    public CT05_UI_MOUSE_RECT leftViewBottomTrigger;

    [HideInInspector]
    public enum UI_POSITION_OBJECT_BUTTON
    {
        UPOB00_MIDDLE_VIEW_RIGHT,
        UPOB01_MIDDLE_VIEW_LEFT,

        UPOB03_RIGHT_VIEW_LEFT,

        UPOB04_LEFT_VIEW_RIGHT
    }
    
    private void Awake()
    {
        currentLerpTime = 0;

        rightObjectTypeTwo.gameObject.SetActive(false);
        leftObjectTypeTwo.gameObject.SetActive(false);

        rightObjectTypeOne.gameObject.SetActive(true);
        leftObjectTypeOne.gameObject.SetActive(true);

        rightObjectUiHolderOne.position = exitRight.position;
        leftObjectUiHolderOne.position = exitLeft.position;

        rightObjectUiHolderTwo.position = exitRight.position;
        leftObjectUiHolderTwo.position = exitLeft.position;
    }


    public bool EnterObject(UI_POSITION_OBJECT_BUTTON buttonIndex)
    {
        switch (buttonIndex)
        {
            case UI_POSITION_OBJECT_BUTTON.UPOB00_MIDDLE_VIEW_RIGHT:
                {
                    return LerpObject(ref rightObjectUiHolderOne, exitRight.position, enterRight.position);
                }

            case UI_POSITION_OBJECT_BUTTON.UPOB01_MIDDLE_VIEW_LEFT:
                {
                    return LerpObject(ref leftObjectUiHolderOne, exitLeft.position, enterLeft.position);
                }

            case UI_POSITION_OBJECT_BUTTON.UPOB03_RIGHT_VIEW_LEFT:
                {
                    return LerpObject(ref leftObjectUiHolderTwo, exitLeft.position, enterLeft.position);
                }

            case UI_POSITION_OBJECT_BUTTON.UPOB04_LEFT_VIEW_RIGHT:
                {
                    return LerpObject(ref rightObjectUiHolderTwo, exitRight.position, enterRight.position);
                }
        }

        return false;
    }

    public bool ExitObject(UI_POSITION_OBJECT_BUTTON buttonIndex)
    {
        switch (buttonIndex)
        {
            case UI_POSITION_OBJECT_BUTTON.UPOB00_MIDDLE_VIEW_RIGHT:
                {
                    return LerpObject(ref rightObjectUiHolderOne, enterRight.position, exitRight.position);
                }
            case UI_POSITION_OBJECT_BUTTON.UPOB01_MIDDLE_VIEW_LEFT:
                {
                    return LerpObject(ref leftObjectUiHolderOne, enterLeft.position, exitLeft.position);
                }
            case UI_POSITION_OBJECT_BUTTON.UPOB03_RIGHT_VIEW_LEFT:
                {
                    return LerpObject(ref leftObjectUiHolderTwo, enterLeft.position, exitLeft.position);
                }
            case UI_POSITION_OBJECT_BUTTON.UPOB04_LEFT_VIEW_RIGHT:
                {
                    return LerpObject(ref rightObjectUiHolderTwo, enterRight.position, exitRight.position);
                }
        }

        return false;
    }

    bool LerpObject(ref Transform button, Vector3 start, Vector3 end)
    {
        float t = currentLerpTime / maxLerpTime;
        if (t > 1)
        {
            t = 1;
        }

        Vector3 result = Vector3.Lerp(start, end, t);
        button.position = result;

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

    public void SetRightObjectTypeOneFlag(bool flag)
    {
        rightObjectTypeOne.gameObject.SetActive(flag);
    }

    public void SetLeftObjectTypeOneFlag(bool flag)
    {
        leftObjectTypeOne.gameObject.SetActive(flag);
    }

    public void SetRightObjectTypeTwoFlag(bool flag)
    {
        rightObjectTypeTwo.gameObject.SetActive(flag);
    }

    public void SetLeftObjectTypeTwoFlag(bool flag)
    {
        leftObjectTypeTwo.gameObject.SetActive(flag);
    }

    public void CheckMiddleViewTrigger(out bool rightTrigger, out bool leftTrigger)
    {
        rightTrigger = middleViewRightTrigger.GetMouseOnTrigger();
        leftTrigger = middleViewLeftTrigger.GetMouseOnTrigger();
    }

    public void CheckRightViewBodyTrigger(out bool checkTrigger)
    {
        checkTrigger = rightViewBodyTrigger.GetMouseOnTrigger();
    }

    public void CheckLeftViewBodyTrigger(out bool checkTrigger)
    {
        checkTrigger = leftViewBodyTrigger.GetMouseOnTrigger();
    }
   
    public bool GetMiddleViewRightClickFlag()
    {
        return middleViewRightTrigger.GetMouseClickTrigger();
    }

    public bool GetMiddleViewLeftClickFlag()
    {
        return middleViewLeftTrigger.GetMouseClickTrigger();
    }

    public bool GetRightViewTopClickFlag()
    {
        return rightViewTopTrigger.GetMouseClickTrigger();
    }

    public bool GetRightViewBottomClickFlag()
    {
        return rightViewBottomTrigger.GetMouseClickTrigger();
    }

    public bool GetLeftViewTopClickFlag()
    {
        return leftViewTopTrigger.GetMouseClickTrigger();
    }

    public bool GetLeftViewBottomClickFlag()
    {
        return leftViewBottomTrigger.GetMouseClickTrigger();
    }

    public void SetMiddleViewRightClickFlag(bool flag)
    {
        middleViewRightTrigger.SetMouseClickFlag(flag);
    }

    public void SetMiddleViewLeftClickFlag(bool flag)
    {
        middleViewLeftTrigger.SetMouseClickFlag(flag);
    }

    public void SetRightViewTopClickFlag(bool flag)
    {
        rightViewTopTrigger.SetMouseClickFlag(flag);
    }

    public void SetRightViewBottomClickFlag(bool flag)
    {
        rightViewBottomTrigger.SetMouseClickFlag(flag);
    }

    public void SetLeftViewTopClickFlag(bool flag)
    {
        leftViewTopTrigger.SetMouseClickFlag(flag);
    }

    public void SetLeftViewBottomClickFlag(bool flag)
    {
        leftViewBottomTrigger.SetMouseClickFlag(flag);
    }

    public void SetMiddleViewRightActiveFlag(bool flag)
    {
        middleViewRightTrigger.SetObjectActiveFlag(flag);
    }

    public void SetMiddleViewLeftActiveFlag(bool flag)
    {
        middleViewLeftTrigger.SetObjectActiveFlag(flag);
    }

    public void SetRightViewActiveFlag(bool flag)
    {
        leftObjectTypeTwo.gameObject.SetActive(flag);
    }

    public void SetRightBodyFlag(bool flag)
    {
        rightViewBodyTrigger.SetMouseClickFlag(flag);
    }

    public void SetLeftBodyFlag(bool flag)
    {
        leftViewBodyTrigger.SetMouseClickFlag(flag);
    }
}
