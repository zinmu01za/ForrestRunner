using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;
    //
    public static bool Victory;
    public GameObject YOUWINPANEL;
    //
    
    
    
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;
        //
        Victory = false;
        Time.timeScale = 1;
        //
  
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }

        //

        if (Victory)
        {
            Time.timeScale = 0;
            YOUWINPANEL.SetActive(true);
        }

       
    }
}
