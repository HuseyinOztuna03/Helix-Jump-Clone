using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform ball;
    private Vector3 remainder;
    public float smoothness;
    void Start()
    {
        remainder = transform.position - ball.position;
    }


    void  FixedUpdate()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, remainder + ball.position, smoothness);
        transform.position = newPos;
    }
}
