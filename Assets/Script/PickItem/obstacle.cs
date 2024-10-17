using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;
    //
    public GameObject thePlayer;
    public GameObject charModel;
    public AudioSource crashThud;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerRun>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
        crashThud.Play();
        gameOverPanel.SetActive(true);
 
    }

}
