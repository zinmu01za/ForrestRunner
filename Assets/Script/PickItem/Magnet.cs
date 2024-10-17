using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{

    public GameObject coinDetectorObj;
    // Start is called before the first frame update
    void Start()
    {
        coinDetectorObj = GameObject.FindGameObjectWithTag("coin detector");
        coinDetectorObj.SetActive(true);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine(Activatecoin());
            Destroy(transform.GetChild(0).gameObject);
        }
    }

    IEnumerator Activatecoin()
    {
        coinDetectorObj.SetActive(true);
        yield return new WaitForSeconds(10f);
        coinDetectorObj.SetActive(false);
    }


}
