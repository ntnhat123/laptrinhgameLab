using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMovement : MonoBehaviour
{
    public float speed = 5;
    public float maxx = 7.5f;

    float movementHorizontal;

    void Start()
    {

    }

    void Update()
    {
        movementHorizontal = Input.GetAxis("Horizontal");
        if ((movementHorizontal > 0 && transform.position.x < maxx) || (movementHorizontal < 0 && transform.position.x > -maxx))
        {
            transform.position += Vector3.right * movementHorizontal * speed * Time.deltaTime;
        }
    }
}
