using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Created this script from our PipeMoveScript and removed it from the main project hierarchy.

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    // Timer to stop the code and then restart it, so that the pipes are not constant:
    public float spawnRate = 2;
    private float timer = 0;
    // change y axis of pipes:
    public float heightOffset = 8;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        // Timer code:
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }
    // To get pipes to spawn sooner at the start of the game:
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        // Random Range - for the x,y,z positions of pipes: 
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
