﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerUnit2 : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float boundry = -10.0f;
    public GameObject projectPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < boundry)
        {
            transform.position = new Vector3(boundry, transform.position.y, transform.position.z);
        }

        if (transform.position.x > boundry * -1)
        {
            transform.position = new Vector3(boundry * -1, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(projectPrefab, transform.position, projectPrefab.transform.rotation);
        }
    }
}