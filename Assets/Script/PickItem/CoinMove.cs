using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMove : MonoBehaviour
{
    RotateCoin rotateCoinScript;
    void Start()
    {
        rotateCoinScript = gameObject.GetComponent<RotateCoin>();
    }

    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, rotateCoinScript.playerTransform.position,
            rotateCoinScript.speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player Bubble")
        {
            Destroy(gameObject);
        }
    }


}
