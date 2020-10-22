using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TLO4_TITLE_IMAGE_MANAGER : MonoBehaviour
{
    TL02_TITLE_EFFECT[] titleLetterEffectArray = new TL02_TITLE_EFFECT[4];

    bool[] letterEffectFlag = new bool[4];

    float currentWaitTimeBeforeScraperOn;
    float maxWaitTimeBeforeScrperOn;

    void Start()
    {
        foreach (Transform child in transform)
        {
            if (child.name == "V")
            {
                titleLetterEffectArray[0] = child.GetComponent<TL02_TITLE_EFFECT>();
            }
            else if (child.name == "E")
            {
                titleLetterEffectArray[1] = child.GetComponent<TL02_TITLE_EFFECT>();
            }
            else if (child.name == "I")
            {
                titleLetterEffectArray[2] = child.GetComponent<TL02_TITLE_EFFECT>();
            }
            else if(child.name == "L")
            {
                titleLetterEffectArray[3] = child.GetComponent<TL02_TITLE_EFFECT>();
            }
        }

        for (int i = 0; i < letterEffectFlag.Length; i++)
        {
            letterEffectFlag[i] = false;
        }

        currentWaitTimeBeforeScraperOn = 0;
        maxWaitTimeBeforeScrperOn = Random.Range(2, 5);
    }


    public void UpdateScript()
    {
        if (currentWaitTimeBeforeScraperOn > maxWaitTimeBeforeScrperOn)
        {
            StartScraperEffect();
        }
        else
        {
            currentWaitTimeBeforeScraperOn += Time.deltaTime;
        }

        for (int i = 0; i < titleLetterEffectArray.Length; i++)
        {
            titleLetterEffectArray[i].UpdateScript();
        }
    }

    void StartScraperEffect()
    {
        currentWaitTimeBeforeScraperOn = 0;
        maxWaitTimeBeforeScrperOn = Random.Range(2, 5);

        SetScraperEffectOn(Random.Range(0, 4));
    }

    void SetScraperEffectOn(int index)
    {
        if (index > 3)
        {
            index = 3;
        }
        titleLetterEffectArray[index].SetScraperEffectOn();
    }


}
