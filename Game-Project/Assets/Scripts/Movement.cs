using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float MovementSpeed = 10f;
    public float RotateSpeed = 10f;
    public float jump = 10f;
    public Rigidbody rb;
    

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * MovementSpeed * Time.deltaTime);     
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * MovementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -RotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, RotateSpeed * Time.deltaTime);

        }
        
    }
    void FixedUpdate()
    {
         if (Input.GetKeyDown("space"))
            {
            rb.AddForce(transform.up * jump);
            //Debug.Log("Jump");
            }
         
    }
}
