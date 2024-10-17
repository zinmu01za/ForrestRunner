using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;
public class levelClear : MonoBehaviour
{
    void Start()
    {
        if (PlayerPrefs.HasKey("LevelClear"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("LevelClear", 0);
            if (PlayerPrefs.HasKey("LevelClearCount"))
            {

            }
            else
            {
                PlayerPrefs.SetInt("LevelClearCount", 0);
            }
        }
    }

    public void LevelClear()
    {
        int previousBuildIndex = PlayerPrefs.GetInt("LevelClear");
        int currentBuildIndex = UnitySceneManager.GetActiveScene().buildIndex;
        int previousLevelCount = PlayerPrefs.GetInt("LevelClearCount");

        if(currentBuildIndex > previousBuildIndex)
        {
            PlayerPrefs.SetInt("LevelClear", UnitySceneManager.GetActiveScene().buildIndex);
            PlayerPrefs.SetInt("LevelClearCount", previousLevelCount + 1);
        }
        UnitySceneManager.LoadScene(UnitySceneManager.GetActiveScene().buildIndex + 1);
    }

    void Update()
    {
        
    }
}
