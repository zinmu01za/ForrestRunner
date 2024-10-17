using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;

public class levelScript : MonoBehaviour
{
    
    void Start()
    {
        disableAll();
        if (!PlayerPrefs.HasKey("LevelClearCount"))
            PlayerPrefs.SetInt("LevelClearCount", 0);

        int clearLevel = PlayerPrefs.GetInt("LevelClearCount");
        for(int i = 0; i < clearLevel+1; ++i)
        {
            transform.GetChild(i).gameObject.GetComponent<Button>().interactable = true;
        }

    }

    void Update()
    {
        
    }

    public void disableAll()
    {
        int levelButtonsCount = transform.childCount;
        for(int i=0; i < levelButtonsCount; ++i)
        {
            transform.GetChild(i).GetComponent<Button>().interactable = false;
        }
    }

    public void playLevel(int level = 0)
    {
        UnitySceneManager.LoadScene(level);
    }

}
