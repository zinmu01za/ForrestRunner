using System.Collections;
using System.Collections.Generic;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;
using UnityEngine;

public class Events3 : MonoBehaviour
{

    public void ReplayGame()
    {
        UnitySceneManager.LoadScene("Level2");
    }

    public void QuitGame()
    {
        UnitySceneManager.LoadScene("MainMenu");
    }

}