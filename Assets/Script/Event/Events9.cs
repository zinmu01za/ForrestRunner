using System.Collections;
using System.Collections.Generic;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;
using UnityEngine;

public class Events9 : MonoBehaviour
{

    public void ReplayGame()
    {
        UnitySceneManager.LoadScene("Level8");
    }

    public void QuitGame()
    {
        UnitySceneManager.LoadScene("MainMenu");
    }

}
