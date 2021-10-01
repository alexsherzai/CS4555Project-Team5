using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public CharacterController controller;

    public float movSpeed = 5.0f;
    public float rotateSpeed = 100.0f;

    public float gravity = -9.81f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;


        }
        if (Input.GetKey("w"))
        {
            Vector3 movement = new Vector3(0.0f, 0.0f, 1.0f * Time.deltaTime * movSpeed);
            movement = transform.TransformDirection(movement);
            controller.Move(movement);
        }
        if (Input.GetKey("a"))
        {
            Vector3 rotation = new Vector3(0.0f, -1.0f * Time.deltaTime * rotateSpeed, 0.0f);
            transform.Rotate(rotation);
        }
        if (Input.GetKey("s"))
        {
            Vector3 movement = new Vector3(0.0f, 0.0f, -1.0f * Time.deltaTime * movSpeed);
            movement = transform.TransformDirection(movement);
            controller.Move(movement);
        }
        if (Input.GetKey("d"))
        {
            Vector3 rotation = new Vector3(0.0f, 1.0f * Time.deltaTime * rotateSpeed, 0.0f);
            transform.Rotate(rotation);
        }

        velocity.y += gravity * Time.deltaTime * Time.deltaTime;

        controller.Move(velocity);
    }
}