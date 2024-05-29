using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlayUI : MonoBehaviour
{
    // Start is called before the first frame update
    //string activeScene = SceneManager.GetActiveScene().name;

    public Text gameOverText;
    public Text score;

    // Make a timer to count the score
    public float timer = 0.0f;

    public void Start()
    {
        ResetUI();
    }

    // After Start() is called, Awake() is called
    public void Awake()
    {
        // Reset the timer
        timer = 0.0f;

    }


    public void ResetGame()
    {
        SceneManager.LoadScene("Gameplay");
        //ResetUI();
    }


    public void HomeButton()
    {
        SceneManager.LoadScene("Menu");
     
        //ResetUI();
    }

    public void ResetUI( )
    {
        Player.isDestroyed = false;
        gameOverText.text = "";
    }

    public string RenderTimeTwoDecimals(float time)
    {
        return time.ToString("0.00");
    }

    public void FixedUpdate()
    {
        if (!Player.isDestroyed && score)
        {
            timer += Time.deltaTime;
            // Debug.Log("Timer: " + timer);
            score.text = "Score: " + RenderTimeTwoDecimals(timer);
        }


        if (Player.isDestroyed && gameOverText)
        {
            gameOverText.text = "Game Over!!";

            // Show the score
            // score.text = "Score: " + (int)timer;
        }
    }
}
