using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickItem : MonoBehaviour
{

    private int coin = 0;
    public Text CoinDisplayText;
    private AudioSource audioSource;
    public AudioClip ItemSound;
    public AudioClip completeSound;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (PlayerPrefs.HasKey("coin"))
        {
            coin = PlayerPrefs.GetInt("coin");
        }
        CoinDisplayText.text = "coin : " + coin.ToString();
    }


    private void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.tag.Equals("coin"))
        {
            Destroy(target.gameObject);
            coin += 1;
            CoinDisplayText.text = "coin : " + coin.ToString();
            PlayerPrefs.SetInt("coin", coin);
            audioSource.PlayOneShot(ItemSound);
            scoremanager.instance.AddPoint();
        }
        if (target.gameObject.tag.Equals("magnet"))
        {
            audioSource.PlayOneShot(ItemSound);
        }
        if (target.gameObject.tag.Equals("SpeedBoost"))
        {
            audioSource.PlayOneShot(ItemSound);
        }
       
    }


}
