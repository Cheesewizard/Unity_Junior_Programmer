using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerUnit1 : MonoBehaviour
{
    // Start is called before the first frame update

    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardlInput;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       // Gets player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardlInput = Input.GetAxis("Vertical");

        // move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardlInput);
        transform.Rotate(Vector3.up,  turnSpeed * horizontalInput * Time.deltaTime);
    }
}
