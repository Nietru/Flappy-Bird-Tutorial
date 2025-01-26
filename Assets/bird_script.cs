using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_script : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // re-use the code from the PipeMiddleScript to get the reference to the LogicScript.
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
        // if the user presses space, the code will execute:
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true) // Bird will only flap if the bird is alive.
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
