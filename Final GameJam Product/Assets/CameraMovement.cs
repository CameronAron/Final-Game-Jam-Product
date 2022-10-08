using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float moveSpeed = 9f;

    public Rigidbody2D rb;

    //public Transform fuck;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = new Vector3(0, 0, -1);
        }
    }

    void FixedUpdate()
    {
        if (rb.position.x > 10.001)
        {
            transform.position = new Vector3(10, transform.position.y, -1);
            //transform.position.x = 5.39;
        }

        if (rb.position.x < -10.001)
        {
            transform.position = new Vector3(-10, transform.position.y, -1);
            //transform.position.x = 5.39;
        }

        if (rb.position.y > 5.001)
        {
            transform.position = new Vector3(transform.position.x, 5, -1);
            //transform.position.x = 5.39;
        }

        if (rb.position.y < -5.001)
        {
            transform.position = new Vector3(transform.position.x, -5, -1);
            //transform.position.x = 5.39;
        }

        
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);        
        
    }
}
