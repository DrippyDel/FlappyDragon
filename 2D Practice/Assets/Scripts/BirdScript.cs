using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Creating a Reference to this script in the Rigid 
    public Rigidbody2D myRigidbody;

    // Variable reference
    public float jumpStrength;

    public Logic logic;

    public bool birdIsAlive = true;

    // Bounds to how high and low the GameObject can go
    public float Negdeadzone = -10;
    public float Posdeadzone = 10;

    // Start is called before the first frame update
    void Start()
    {
         // Locates the logic tag that is attached to our logic manger
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {   
        // Checks if the space key was pressed
        // If so GameObject would jump
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
            myRigidbody.velocity = Vector2.up * jumpStrength; 
        }

        // If the GameObject goes too high or too low game would end
        if (transform.position.y < Negdeadzone || transform.position.y > Posdeadzone )
        {
            logic.gameOver();
            birdIsAlive = false;
            Destroy(gameObject);
        }
    }

    // When the GameObject hits a pipe the gameOver function would be called
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
         
        // When GameObject hits a pipe this variable is set to false
        birdIsAlive = false;
    }
}
