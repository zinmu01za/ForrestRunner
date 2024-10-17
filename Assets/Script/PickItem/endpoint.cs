using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endpoint : MonoBehaviour
{
  
    public static bool Victory;
    public GameObject YOUWINPANEL;
    //
    public GameObject thePlayer;
    public GameObject charModel;
    public AudioSource WinThud;
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerRun>().enabled = false;
        charModel.GetComponent<Animator>().Play("Twist Dance");
        WinThud.Play();
        YOUWINPANEL.SetActive(true);

    }
}
