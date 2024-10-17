using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpSlide : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetBool("jumping", true);
            Invoke("stopJumping", 0.1f);
        }
       

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetBool("sliding", true);
            Invoke("stopSlideing", 0.1f);
        }

    }

    void stopJumping()
    {
        animator.SetBool("jumping", false);
    }

    void stopSlideing()
    {
        animator.SetBool("sliding", false);

    }

}
