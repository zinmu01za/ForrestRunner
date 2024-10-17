using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCar : MonoBehaviour
{
    public Vector3 moveDirection;
    public float speed;
    public Transform target;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        Vector3 a = transform.position;
        Vector3 b = target.position;
        transform.Translate(moveDirection, Space.Self);
        transform.position = Vector3.MoveTowards(a,b, speed);

    }

}
