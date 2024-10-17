using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public float speed = 100f;

    public Transform playerTransform;
    CoinMove coinMoveScript;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        coinMoveScript = gameObject.GetComponent<CoinMove>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "coin detector")
        {
            coinMoveScript.enabled = true;
        }
    }



    void Update()
    {
        transform.Rotate(0, 50 * Time.deltaTime, 0);
    }
}
