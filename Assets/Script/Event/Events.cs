using System.Collections;
using System.Collections.Generic;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;
using UnityEngine;

public class Events : MonoBehaviour
{

    public void ReplayGame()
    {
        UnitySceneManager.LoadScene("Level");
    }

    public void QuitGame()
    {
        UnitySceneManager.LoadScene("MainMenu");
    }

}
