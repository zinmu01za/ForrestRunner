using System.Collections;
using System.Collections.Generic;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;
using UnityEngine;

public class Events2 : MonoBehaviour
{

    public void ReplayGame()
    {
        UnitySceneManager.LoadScene("Level1");
    }

    public void QuitGame()
    {
        UnitySceneManager.LoadScene("MainMenu");
    }

}
