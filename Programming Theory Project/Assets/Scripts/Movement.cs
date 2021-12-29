using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    float horizontal;
    float xPos = 4.4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector3.right * horizontal * speed * Time.deltaTime);
        Xcoordinate();
    }

    private void Xcoordinate()
    {
        if (transform.position.x < -xPos)
        {
            transform.position = new Vector3(-xPos, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xPos)
        {
            transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
        }
    }
}
