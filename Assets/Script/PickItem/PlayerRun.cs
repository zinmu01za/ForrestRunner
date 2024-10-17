using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRun : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 direction;
    public float forwardSpeed;
    private float normalSpeed;
    public float boostedSpeed;
    public float speedCoolDown;
    private int  desiredLane = 1;//0:left 1:middle 2:right
    public float laneDistance = 28;//the distance between two lane

    public float jumpForce;
    public float Gravity = -80;

    public CharacterController Player;
    private Animator animator;


    void Start()
    {
        normalSpeed = forwardSpeed;
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        Player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.z = forwardSpeed;

        direction.y += Gravity * Time.deltaTime;
        if (controller.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Jump();
            }
        }

        
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetBool("sliding", true);
            Invoke("stopSlideing", 0.1f);
            Player.height = 1.43f;
        }
        

        //Gather the input on which lane we should be

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            desiredLane++;
            if (desiredLane == 3)
                desiredLane = 2;
            Player.height = 1.5f;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            desiredLane--;
            if (desiredLane == -1) 
                desiredLane = 0;
            Player.height = 1.5f;
        }

        Vector3 targetPosition = transform.position.z * transform.forward +  transform.position.y * transform.up;
        if (desiredLane == 0)
        {
            targetPosition += Vector3.left * laneDistance;
        }else if(desiredLane == 2)
        {
            targetPosition += Vector3.right * laneDistance;
        }

        if (transform.position == targetPosition)
            return;
        Vector3 diff = targetPosition - transform.position;
        Vector3 moveDir = diff.normalized * 30 * Time.deltaTime;
        if (moveDir.sqrMagnitude < diff.sqrMagnitude)
            controller.Move(moveDir);
        else
            controller.Move(diff);
    }

    private void FixedUpdate()
    {
        controller.Move(direction * Time.fixedDeltaTime);
    }

    private void Jump()
    {
        direction.y = jumpForce;
        Player.height = 1.5f;
    }

    
    void stopSlideing()
    {
        animator.SetBool("sliding", false);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.tag == "Obstacle")
        {
            obstacle.gameOver = true;
            
        }

        if (hit.transform.tag == "endpoint")
        {
            endpoint.Victory = true;
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SpeedBoost"))
        {
            forwardSpeed = boostedSpeed;
            StartCoroutine("SpeedDuration");
            Destroy(other.gameObject);
        }

    }

    IEnumerator SpeedDuration()
    {
        yield return new WaitForSeconds(speedCoolDown);
        forwardSpeed = normalSpeed;
    }


}
