using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    // Reference to Pipe Prefab
    public GameObject pipe; 
    public float spwanRate = 2;

    // private so its unable to be changed in editor 
    private float timer = 0;

    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        // A pipe would spwan as soon as the game starts
        spwanPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spwanRate)
        {
            timer = timer + Time.deltaTime;
            // time += Time.deltaTime;
        }
        else
        {
            // ReSpawns pipe
            spwanPipe();
            // Resets timer
            timer = 0;
        }
    }

    // ReSpawns pipe function 
    void spwanPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        // ReSpawns pipe                  pipe's x position   pipe's y position         pipe's z position   pipe's orientation
         Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint), 0), transform.rotation);
    }
}
