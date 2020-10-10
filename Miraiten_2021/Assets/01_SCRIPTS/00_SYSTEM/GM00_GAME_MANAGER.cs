using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM00_GAME_MANAGER : MonoBehaviour
{
    public static GM00_GAME_MANAGER instance;

    private void Awake()
    {
        if (instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
