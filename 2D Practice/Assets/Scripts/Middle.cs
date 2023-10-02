using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Middle : MonoBehaviour
{

    public Logic logic;

    // Start is called before the first frame update
    void Start()
    {
        // Locates the logic tag that is attached to our logic manger
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // When ever an object first hits the trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // would add score (Make sure you find the logic tag in start first!!)
        logic.addScore();
    }
}
