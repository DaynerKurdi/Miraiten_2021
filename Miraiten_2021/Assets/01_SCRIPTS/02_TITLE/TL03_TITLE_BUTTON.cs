using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TL03_TITLE_BUTTON : MonoBehaviour
{
    Image uiEffect;
    Color startColor;
    Color endColor;

    Color startLerp;
    Color endLerp;

    float maxTimeLerp = 0.4f;

    int flashIndex = 0;
    bool stopLerpFlag = false;

    private void Awake()
    {
        uiEffect = transform.GetChild(0).GetComponent<Image>();

        endColor = uiEffect.color;
        startColor = endColor;

        endColor.a = 0;

        startLerp = startColor;
        endLerp = endColor;

        flashIndex = 0;

        stopLerpFlag = false;

        SetHighLightFlagOff();
    }

    public void SetHightLightFlagOn(int flashDirection)
    {
        uiEffect.gameObject.SetActive(true);

        flashIndex = flashDirection;

        if (flashIndex == 0)
        {
            startLerp = startColor;
            endLerp = endColor;
        }
        else
        {
            startLerp = endColor;
            endLerp = startColor;
        }
    }

    public int SetHighLightFlagOff()
    {
        uiEffect.gameObject.SetActive(false);

        return flashIndex;
    }

    public void SetStopLerpFlagOn()
    {
        stopLerpFlag = true;
        uiEffect.color = startColor;
    }

    public bool LerpProcess(float currentLerpTime)
    {
        if (stopLerpFlag)
        {
            return false;
        }

        float t = currentLerpTime / maxTimeLerp;
        if (t >=1)
        {
            t = 1;
        }

        Color result = Color.Lerp(startLerp, endLerp, t);
        uiEffect.color = result;

        if (currentLerpTime >= maxTimeLerp)
        {
            if (flashIndex == 0)
            {
                startLerp = endColor;
                endLerp = startColor;

                flashIndex = 1;
            }
            else
            {
                startLerp = startColor;
                endLerp = endColor;

                flashIndex = 0;
            }

            return true;
        }

        return false;
    }
}
