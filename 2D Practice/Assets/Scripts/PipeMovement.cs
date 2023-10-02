using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    // Variable for how fast the pipes would move
    public float moveSpeed;

    public float deadzone = -14;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // To move the pipe smoothly along the screen
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        // Deletes pipe after it moves off screen
        if (transform.position.x < deadzone)
        {
            Destroy(gameObject);
        }
    }
}
