using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float playerSpeed = 4f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        move();
    }
    private void move()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(moveX * playerSpeed, rb.velocity.y, moveZ * playerSpeed);
    }

   
}
