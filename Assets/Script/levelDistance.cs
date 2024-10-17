using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelDistance : MonoBehaviour
{
    public GameObject disDisplay;
    public int disRun;
    public bool addingDis = false;

    void Update()
    {
        if(addingDis == false)
        {
            addingDis = true;
            StartCoroutine(AddingDis());
        }
        


    }

    IEnumerator AddingDis()
    {
        disRun += 1;
        disDisplay.GetComponent<Text>().text = "" + disRun +  " M";
        yield return new WaitForSeconds(0.25f);
        addingDis = false;
    }

  
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {

           addingDis = true;
           StartCoroutine(AddingDis());
        }
    }


}
