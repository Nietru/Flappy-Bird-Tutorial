using UnityEngine;
using UnityEngine.UI; // Required for Text.

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    [ContextMenu("Increase Score")] // Adds a button to the Unity Editor in the 3 dots menu under LogicScript.
    public void addScore()  // Function to increase the score.
    {
        playerScore += playerScore;
        scoreText.text = playerScore.ToString();  // ToString() converts the int to a string, because it is a text field.
    }
}
