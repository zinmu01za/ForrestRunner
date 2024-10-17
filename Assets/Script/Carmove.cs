using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carmove : MonoBehaviour
{
    private Vector3 direction;
    public float forwardSpeed;
    private CharacterController controller;
    private int desiredLane = 1;
    public float laneDistance = 27;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.z = forwardSpeed;

        Vector3 targetPosition = transform.position.z * transform.forward;
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
        Vector3 moveDir = diff.normalized * 20 * Time.deltaTime;
        if (moveDir.sqrMagnitude < diff.sqrMagnitude)
            controller.Move(moveDir);
        else
            controller.Move(diff);

    }

    private void FixedUpdate()
    {
        controller.Move(direction * Time.fixedDeltaTime);
    }

}
