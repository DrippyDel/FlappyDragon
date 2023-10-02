using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Importing the UI library 
using UnityEngine.UI;
// Importing the SceneManagement library
using UnityEngine.SceneManagement;

public class Logic : MonoBehaviour
{
    // No need for float since we only want whole numbers
    // Remember float = decimals, int = integers 
    public int playerScore;

    // Reference to our text field in Unity 
    public Text scoreText;

    // Reference to our Game Over text & button
    public GameObject gameOverScreen;

    // To test if the function works
    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore = playerScore + 1;
        // playerScore += 1;

        // Updates our score text
        scoreText.text =playerScore.ToString();
    }

    public void restartGame() 
    {
        // Calls the most current scence (Which is the main one)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {   
        // Shows the Game Over text on screen
        gameOverScreen.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
