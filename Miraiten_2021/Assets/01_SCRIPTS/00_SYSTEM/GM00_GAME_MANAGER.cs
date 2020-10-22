﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM00_GAME_MANAGER : MonoBehaviour
{
    public enum GM_GAME_SCENE
    {
        GM00_TITLE,
        GM01_MAIN_GAME,
        GM02_GAME_RESULT
    }

    public static GM00_GAME_MANAGER instance;
   
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void SetSenceToMainGame()
    {
        SceneManager.LoadScene(1);
    }


    //void OnGUI()
    //{
    //    if (GUI.Button(new Rect(10, 10, 100, 30), "Change Scene"))
    //    {
    //        Scene currentScene = SceneManager.GetActiveScene();
    //        int currentSceneIndex = currentScene.buildIndex;

    //        Debug.Log("Scene loading: ");

    //        switch (currentSceneIndex)
    //        {

    //            case 0:
    //                {
    //                    SceneManager.LoadScene(1);
    //                }
    //                break;

    //            case 1:
    //                {
    //                    SceneManager.LoadScene(2);
    //                }
    //                break;

    //            case 2:
    //                {
    //                    SceneManager.LoadScene(0);
    //                }
    //                break;
    //        }
            
    //    }
    //}
}
