using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CT05_UI_MOUSE_RECT : MonoBehaviour
{
    public bool mouseOn;
    public bool mouseClick;

    public void Awake()
    {
        mouseOn = false;
    }

    public void MouseHasEnter()
    {
        mouseOn = true;
    }

    public void MouseHasExit()
    {
        mouseOn = false;
        mouseClick = false;
    }

    public void MouseHasBeenClick()
    {
        mouseClick = true;
    }

    public bool GetMouseOnTrigger()
    {
        return mouseOn;
    }

    public bool GetMouseClickTrigger()
    {
        return mouseClick;
    }

    public void SetMouseClickFlag(bool flag)
    {
        mouseOn = flag;
        mouseClick = flag;
    }

    public void SetObjectActiveFlag(bool flag)
    {
        mouseOn = flag;
        mouseClick = flag;
    }

}
