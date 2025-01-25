using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic; // This is the reference to the LogicScript.
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Created a tag called "Logic" in the Unity Editor and assigned it to the Logic Manager GameObject.
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); // This is how you get the reference to the LogicScript.
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addScore(); // Calls the addScore function from the LogicScript.
    }
}
