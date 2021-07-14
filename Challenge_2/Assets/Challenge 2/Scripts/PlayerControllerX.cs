using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float keyDelay = 2.0f;

    private float previousTime = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Delays pressing the space key again for x seconds. 
            var time = Time.time;
            var deltaTime = time - previousTime;

            if(deltaTime > keyDelay)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                previousTime = time;
            }
        }
    }
}
