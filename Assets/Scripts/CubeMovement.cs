using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float speed = 5.0f;
    private float turnSpeed = 50.0f;
    public float horizontalInput;
    public float verticalInput;
    public int jumpingDistance = 30;
    private bool jumpKey;
    private Rigidbody rigidbodyComponent;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        // transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput );
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);

        if(Input.GetKeyDown("space") && transform.position.y <= 1) {
            jumpKey = true;
        }

    }

    private void FixedUpdate() {

        if (jumpKey) {
            rigidbodyComponent.AddForce(Vector3.up * jumpingDistance, ForceMode.VelocityChange);
            jumpKey = false;
        }

    }
}
