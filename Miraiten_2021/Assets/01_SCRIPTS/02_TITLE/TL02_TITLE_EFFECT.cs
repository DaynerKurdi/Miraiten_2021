using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TL02_TITLE_EFFECT : MonoBehaviour
{
    RectTransform baseChild;
    RectTransform[] effectChild = new RectTransform[3];

    bool startEffect;
    int effectIndex;
    int currentNumberOfEffectRound = 0;
    int maxNumberOfEffectRound = 10;

    float currentWaitTimeBeforeSwitch = 0;
    float maxWaitTimeBeforeSwitch = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        foreach (RectTransform child in transform)
        {
            if (child.name == "base")
            {
                baseChild = child;
            }
            else if (child.name == "effect_1")
            {
                effectChild[0] = child;
                effectChild[0].gameObject.SetActive(false);
            }
            else if (child.name == "effect_2")
            {
                effectChild[1] = child;
                effectChild[1].gameObject.SetActive(false);
            }
            else if (child.name == "effect_3")
            {
                effectChild[2] = child;
                effectChild[2].gameObject.SetActive(false);
            }
        }

        startEffect = false;
        effectIndex = 0;
        currentWaitTimeBeforeSwitch = 0;
        currentNumberOfEffectRound = 0;
    }

    public void UpdateScript()
    {
        if (startEffect)
        {
            ImageScraperEffect();
        }
    }

    void ImageScraperEffect()
    {
        if (currentWaitTimeBeforeSwitch >= maxWaitTimeBeforeSwitch)
        {
            currentWaitTimeBeforeSwitch = 0;

            effectChild[effectIndex].gameObject.SetActive(false);

            effectIndex++;

            if (effectIndex >= effectChild.Length)
            {
                effectIndex = 0;
                if (currentNumberOfEffectRound == maxNumberOfEffectRound)
                {
                    currentNumberOfEffectRound = 0;
                    SetScraperEffectOff();
                }
                else
                {
                    currentNumberOfEffectRound++;
                }
            }

            if (startEffect)
            {
                effectChild[effectIndex].gameObject.SetActive(true);
            }
        }
        else
        {
            currentWaitTimeBeforeSwitch += Time.deltaTime;
        }
    }

    public void SetScraperEffectOn()
    {
        startEffect = true;
        effectIndex = 0;
        currentWaitTimeBeforeSwitch = 0;
        currentNumberOfEffectRound = 0;
        baseChild.gameObject.SetActive(false);
        effectChild[effectIndex].gameObject.SetActive(true);
    }

    public void SetScraperEffectOff()
    {
        startEffect = false;
        effectIndex = 0;
        currentWaitTimeBeforeSwitch = 0;
        currentNumberOfEffectRound = 0;
        baseChild.gameObject.SetActive(true);

        effectChild[0].gameObject.SetActive(false);
        effectChild[1].gameObject.SetActive(false);
        effectChild[2].gameObject.SetActive(false);
    }
}
