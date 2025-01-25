using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    // add a float to remove pipes once they are off-screen to the left, i chose at -25 on the x-axis, to free up memory.
    public float deadZone = -25;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime assures the multiplication is consistent and not dependant on frame-rate of varying Operating systems.
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime; 

        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted!!!");  // You can see this in Unity in the Console.
            Destroy(gameObject);  // Goodbye offscreen pipes!
        }
    }
}
