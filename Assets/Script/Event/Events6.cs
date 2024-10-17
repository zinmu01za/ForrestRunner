using System.Collections;
using System.Collections.Generic;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;
using UnityEngine;

public class Events6 : MonoBehaviour
{

    public void ReplayGame()
    {
        UnitySceneManager.LoadScene("Level5");
    }

    public void QuitGame()
    {
        UnitySceneManager.LoadScene("MainMenu");
    }

}
