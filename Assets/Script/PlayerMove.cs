using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour

{
    private Animator animator;
    private CharacterController controller;
    private Vector3 direction;
    public float forwardSpeed;


    private int desiredLane = 1;//0:left 1:middle 2:right
    public float laneDistance = 27;//the distance between two lane


    void Start()
    {
        // lane = 0;
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();


    }

    void Update()
    {
        //run
        direction.z = forwardSpeed;

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            desiredLane++;
            if (desiredLane == 3)
                desiredLane = 2;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            desiredLane--;
            if (desiredLane == -1)
                desiredLane = 0;
        }

        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;
        if (desiredLane == 0)
        {
            targetPosition += Vector3.left * laneDistance;
        }
        else if (desiredLane == 2)
        {
            targetPosition += Vector3.right * laneDistance;
        }

        //transform.position = Vector3.Lerp(transform.position,targetPosition, 70 * Time.fixedDeltaTime);
        if (transform.position == targetPosition)
            return;
            Vector3 diff = targetPosition - transform.position;
            Vector3 moveDir = diff.normalized * 30 * Time.deltaTime;
        if (moveDir.sqrMagnitude < diff.sqrMagnitude)
            controller.Move(moveDir);
        else
            controller.Move(diff);
        
        //jump
/*
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
*/
    }
/*
    void stopJumping()
    {
        animator.SetBool("jumping", false);
    }

    void stopSlideing()
    {
        animator.SetBool("sliding", false);
    }
*/
    private void FixedUpdate()
    {
        controller.Move(direction * Time.fixedDeltaTime);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.transform.tag == "Obstacle")
        {
            PlayerManager.gameOver = true;
        }
    }



}
