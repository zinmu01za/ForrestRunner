using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoremanager : MonoBehaviour
{
    public static scoremanager instance;

    public Text scoreText;
    public Text highscoreText;

    int score = 0;
    int highscore = 0;

    private void Awake()
    {
        instance = this;
    }


    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = score.ToString() + " SCORE COIN";
        highscoreText.text = "HIGHSCORE COIN : " + highscore.ToString();
    }

    // Update is called once per frame
    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + " SCORE COIN";
        if(highscore < score)
        PlayerPrefs.SetInt("highscore", score);
    }

  
}
