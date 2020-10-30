using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TL01_TITLE_MENU : MonoBehaviour
{
    public enum ButtonIndex
    {
        BT00_START,
        BT01_BUTTON_TWO,
        BT03_EXIT
    }

    public TL03_TITLE_BUTTON[] titleButton = new TL03_TITLE_BUTTON[3];
    ButtonIndex buttonIndex = ButtonIndex.BT00_START;
    float currentLerp = 0;

    bool upButtonFlag = false;
    bool downButtonFlag = false;
    bool actionButtonFlag = false;

    bool buttonHasSelectedFlag = false;

    private void Start()
    {
        buttonIndex = ButtonIndex.BT00_START;

        titleButton[0].SetHightLightFlagOn(0);

        currentLerp = 0;

        buttonHasSelectedFlag = false;

        ResetButtonFlag();
    }

    private void OnEnable()
    {
        IP00_INPUT_MANAGER.instance.TitleActionTriggredEvent += SetActionFlagOn;
        IP00_INPUT_MANAGER.instance.TitleUpButtonTriggredEvent += SetUpButtonFlagOn;
        IP00_INPUT_MANAGER.instance.TitleDownButtonTriggredEvent += SetDownButtonFlagOn;
    }

    private void OnDisable()
    {
        IP00_INPUT_MANAGER.instance.TitleActionTriggredEvent -= SetActionFlagOn;
        IP00_INPUT_MANAGER.instance.TitleUpButtonTriggredEvent -= SetUpButtonFlagOn;
        IP00_INPUT_MANAGER.instance.TitleDownButtonTriggredEvent -= SetDownButtonFlagOn;
    }

    public void UpdateScript()
    {
        if (!buttonHasSelectedFlag)
        {
            TitleFlashingProsses();
        }
    }

    void TitleFlashingProsses()
    {
        switch (buttonIndex)
        {
            case ButtonIndex.BT00_START:
                {
                    if (actionButtonFlag)
                    {
                        SetActiveButtonOn(0);

                        ResetButtonFlag();

                        GM00_GAME_MANAGER.instance.SetSenceToMainGame();
                    }
                    else if (upButtonFlag)
                    {
                        SetNextButton(ButtonIndex.BT03_EXIT);

                        ResetButtonFlag();
                    }
                    else if (downButtonFlag)
                    {
                        SetNextButton(ButtonIndex.BT01_BUTTON_TWO);

                        ResetButtonFlag();
                    }

                    HighLightFlasing(0);
                }
                break;
            case ButtonIndex.BT01_BUTTON_TWO:
                {
                    if (actionButtonFlag)
                    {
                        SetActiveButtonOn(1);

                        ResetButtonFlag();
                    }
                    else if(upButtonFlag)
                    {
                        SetNextButton(ButtonIndex.BT00_START);

                        ResetButtonFlag();
                    }
                    else if (downButtonFlag)
                    {
                        SetNextButton(ButtonIndex.BT03_EXIT);

                        ResetButtonFlag();
                    }

                    HighLightFlasing(1);
                }
                break;
            case ButtonIndex.BT03_EXIT:
                {
                    if (actionButtonFlag)
                    {
                        SetActiveButtonOn(2);

                        ResetButtonFlag();
                    }
                    else if(upButtonFlag)
                    {
                        SetNextButton(ButtonIndex.BT01_BUTTON_TWO);

                        ResetButtonFlag();
                    }
                    else if (downButtonFlag)
                    {
                        SetNextButton(ButtonIndex.BT00_START);

                        ResetButtonFlag();
                    }

                    HighLightFlasing(2);
                }
                break;
        }  
    }

    void ResetButtonFlag()
    {
        upButtonFlag = false;
        downButtonFlag = false;
        actionButtonFlag = false;
    }

    void SetActiveButtonOn(int index)
    {
        buttonHasSelectedFlag = true;

        for (int i = 0; i < titleButton.Length; i++)
        {
            if (i != index)
            {
                titleButton[i].gameObject.SetActive(false);
            }
            else
            {
                titleButton[i].SetStopLerpFlagOn();
            }
        }
    }

    void SetNextButton(ButtonIndex nextIndex)
    {
        int from = 0;
        int to = 0;

        switch (buttonIndex)
        {
            case ButtonIndex.BT00_START:
                {
                    from = 0;
                }
                break;
            case ButtonIndex.BT01_BUTTON_TWO:
                {
                    from = 1;
                }
                break;
            case ButtonIndex.BT03_EXIT:
                {
                    from = 2;
                }
                break;
        }

        switch (nextIndex)
        {
            case ButtonIndex.BT00_START:
                {
                    to = 0;
                }
                break;
            case ButtonIndex.BT01_BUTTON_TWO:
                {
                    to = 1;
                }
                break;
            case ButtonIndex.BT03_EXIT:
                {
                    to = 2;
                }
                break;
        }

        int flashIndex = titleButton[from].SetHighLightFlagOff();
        titleButton[to].SetHightLightFlagOn(flashIndex);

        buttonIndex = nextIndex;
    }

    void HighLightFlasing(int index)
    {
        if (titleButton[index].LerpProcess(currentLerp))
        {
            currentLerp = 0;
        }
        else
        {
            currentLerp += Time.deltaTime;
        }
    }

    void SetActionFlagOn()
    {
        actionButtonFlag = true;
    }

    void SetUpButtonFlagOn()
    {
        upButtonFlag = true;
    }

    void SetDownButtonFlagOn()
    {
        downButtonFlag = true;
    }
}
