using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CT00_CAMERA_TRIGGER_MANAGER : MonoBehaviour
{
    public Transform middleViewRightObject;
    public Transform middleViewLeftObject;

    public Transform rightViewLeftObject;
    public Transform leftViewRightObject;

    [Space(10)]

    public Transform rightUiHolderOne;
    public Transform rightUiHolderTwo;
    public Transform leftUiHolderOne;
    public Transform leftUiHolderTwo;

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

    float currentLerpTime = 0;
    float maxLerpTime = 0.2f;


    [Header("Middle View")]
    public CT05_UI_MOUSE_RECT middleViewRightTrigger;
    public CT05_UI_MOUSE_RECT middleViewLeftTrigger;


    [Header("Right View")]
    public CT05_UI_MOUSE_RECT rightViewBodyTrigger;
    public CT05_UI_MOUSE_RECT rightViewTopTrigger;
    public CT05_UI_MOUSE_RECT rightViewBottomTrigger;


    [Header("Left View")]
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

        SetRightViewObjectActiveFlag(false);
        SetLeftViewObjectActiveFlag(false);

        SetMiddleViewObjectsActiveFlag(true);

        rightUiHolderOne.position = exitRight.position;
        leftUiHolderOne.position = exitLeft.position;

        rightUiHolderTwo.position = exitRight.position;
        leftUiHolderTwo.position = exitLeft.position;
    }


    public bool EnterObject(UI_POSITION_OBJECT_BUTTON buttonIndex)
    {
        switch (buttonIndex)
        {
            case UI_POSITION_OBJECT_BUTTON.UPOB00_MIDDLE_VIEW_RIGHT:
                {
                    return LerpObject(ref rightUiHolderOne, exitRight.position, enterRight.position);
                }

            case UI_POSITION_OBJECT_BUTTON.UPOB01_MIDDLE_VIEW_LEFT:
                {
                    return LerpObject(ref leftUiHolderOne, exitLeft.position, enterLeft.position);
                }

            case UI_POSITION_OBJECT_BUTTON.UPOB03_RIGHT_VIEW_LEFT:
                {
                    return LerpObject(ref leftUiHolderTwo, exitLeft.position, enterLeft.position);
                }

            case UI_POSITION_OBJECT_BUTTON.UPOB04_LEFT_VIEW_RIGHT:
                {
                    return LerpObject(ref rightUiHolderTwo, exitRight.position, enterRight.position);
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
                    return LerpObject(ref rightUiHolderOne, enterRight.position, exitRight.position);
                }
            case UI_POSITION_OBJECT_BUTTON.UPOB01_MIDDLE_VIEW_LEFT:
                {
                    return LerpObject(ref leftUiHolderOne, enterLeft.position, exitLeft.position);
                }
            case UI_POSITION_OBJECT_BUTTON.UPOB03_RIGHT_VIEW_LEFT:
                {
                    return LerpObject(ref leftUiHolderTwo, enterLeft.position, exitLeft.position);
                }
            case UI_POSITION_OBJECT_BUTTON.UPOB04_LEFT_VIEW_RIGHT:
                {
                    return LerpObject(ref rightUiHolderTwo, enterRight.position, exitRight.position);
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

    #region Active Object Flag
    public void SetMiddleViewObjectsActiveFlag(bool flag)
    {
        middleViewRightObject.gameObject.SetActive(flag);
        middleViewLeftObject.gameObject.SetActive(flag);
    }

    public void SetMiddleViewRightObjectActiveFlag(bool flag)
    {
        middleViewRightObject.gameObject.SetActive(flag);
    }

    public void SetMiddleViewObjectLeftViewActiveFlag(bool flag)
    {
        middleViewLeftObject.gameObject.SetActive(flag);
    }

    public void SetRightViewObjectActiveFlag(bool flag)
    {
        rightViewLeftObject.gameObject.SetActive(flag);

        rightViewBodyTrigger.gameObject.SetActive(flag);
        rightViewTopTrigger.gameObject.SetActive(flag);
        rightViewBottomTrigger.gameObject.SetActive(flag);
    }

    public void SetLeftViewObjectActiveFlag(bool flag)
    {
        leftViewRightObject.gameObject.SetActive(flag);

        leftViewBodyTrigger.gameObject.SetActive(flag);
        leftViewTopTrigger.gameObject.SetActive(flag);
        leftViewBottomTrigger.gameObject.SetActive(flag);
    }
    #endregion

    #region Active Trigger Flag

    #region Set Mouse Flag
    public void SetMiddleViewMouseAllFlag(bool flag)
    {
        middleViewRightTrigger.SetMouseClickFlag(flag);
        middleViewRightTrigger.SetMouseOnFlag(flag);

        middleViewLeftTrigger.SetMouseClickFlag(flag);
        middleViewLeftTrigger.SetMouseOnFlag(flag);
    }

    public void SetMiddleViewRightMouseClickFlag(bool flag)
    {
        middleViewRightTrigger.SetMouseClickFlag(flag);
    }

    public void SetMiddleViewLeftMouseClickFlag(bool flag)
    {
        middleViewLeftTrigger.SetMouseClickFlag(flag);
    }

    public void SetRightViewAllMouseClickFlag(bool flag)
    {
        rightViewTopTrigger.SetMouseClickFlag(flag);
        rightViewBottomTrigger.SetMouseClickFlag(flag);
    }

    public void SetRightViewTopMouseClickFlag(bool flag)
    {
        rightViewTopTrigger.SetMouseClickFlag(flag);
    }

    public void SetRightViewBottomMouseClickFlag(bool flag)
    {
        rightViewBottomTrigger.SetMouseClickFlag(flag);
    }

    public void SetLeftViewAllMouseClickFlag(bool flag)
    {
        leftViewTopTrigger.SetMouseClickFlag(flag);
        leftViewBottomTrigger.SetMouseClickFlag(flag);
    }

    public void SetLeftViewTopMouseClickFlag(bool flag)
    {
        leftViewTopTrigger.SetMouseClickFlag(flag);
    }

    public void SetLeftViewBottomMouseClickFlag(bool flag)
    {
        leftViewBottomTrigger.SetMouseClickFlag(flag);
    }
    #endregion

    #region Set Mouse Enter Flag
    public void SetMiddleViewAllEnterFlag(bool flag)
    {
        middleViewRightTrigger.SetMouseOnFlag(flag);
        middleViewLeftTrigger.SetMouseOnFlag(flag);
    }

    public void SetMiddleViewRightEnterFlag(bool flag)
    {
        middleViewRightTrigger.SetMouseOnFlag(flag);
    }

    public void SetMiddleViewLeftEnterFlag(bool flag)
    {
        middleViewLeftTrigger.SetMouseOnFlag(flag);
    }

    public void SetRightViewEnterFlag(bool flag)
    {
        rightViewBodyTrigger.SetMouseOnFlag(flag);
    }

    public void SetLeftViewEnterFlag(bool flag)
    {
        leftViewBodyTrigger.SetMouseOnFlag(flag);
    }
    #endregion
    #endregion

    #region Check Trigger Enter

    public void CheckMiddleViewEnterTrigger(out bool rightTrigger, out bool leftTrigger)
    {
        rightTrigger = middleViewRightTrigger.GetMouseOnTrigger();
        leftTrigger = middleViewLeftTrigger.GetMouseOnTrigger();
    }

    public void CheckRightViewBodyEnterTrigger(out bool checkTrigger)
    {
        checkTrigger = rightViewBodyTrigger.GetMouseOnTrigger();
    }

    public void CheckLeftViewBodyEnterTrigger(out bool checkTrigger)
    {
        checkTrigger = leftViewBodyTrigger.GetMouseOnTrigger();
    }

    #endregion

    #region Mouse Click 
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

    #endregion
    
}
