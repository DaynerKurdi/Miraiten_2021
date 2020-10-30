using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM00_GAME_MANAGER : MonoBehaviour
{
    public static GM00_GAME_MANAGER instance;

    public GS_GAME_SENCE currentGameSence;

   
   
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
        currentGameSence = GS_GAME_SENCE.GS01_MAIN_GAME;
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
