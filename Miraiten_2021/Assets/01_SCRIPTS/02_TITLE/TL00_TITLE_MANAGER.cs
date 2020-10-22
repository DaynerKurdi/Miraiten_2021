using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TL00_TITLE_MANAGER : MonoBehaviour
{
    public TL01_TITLE_MENU titleMenuManager;
    public TLO4_TITLE_IMAGE_MANAGER titleImageManager;

    private void Update()
    {
        titleMenuManager.UpdateScript();
        titleImageManager.UpdateScript();
    }
}
