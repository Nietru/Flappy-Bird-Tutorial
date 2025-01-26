using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required for Text.
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen; // Reference to the Game Over Screen GameObject.

    [ContextMenu("Increase Score")] // Adds a button to the Unity Editor in the 3 dots menu under LogicScript.
    public void addScore(int scoreToAdd)  // Function to increase the score.
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();  // ToString() converts the int to a string, because it is a text field.
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reloads the current scene.
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true); // Sets the Game Over Screen to active.
    }
}
