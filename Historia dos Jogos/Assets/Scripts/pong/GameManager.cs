using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{

    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject Player1Text;
    public GameObject Player2Text;

    private int Player1Score;
    private int Player2Score;

    [Header("Pause Menu")]
    public GameObject pauseMenu; 

    public void Player1Scored()
    {
        if (Player1Score < 2)
        {
            Player1Score++;
        Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        Reset();
        }
        else
        {
             SceneManager.LoadScene("brick_breaker");
        }
       
    }

    public void Player2Scored()
    {
        Player2Score++;
        Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        Reset();

    }

    private void Reset()
    {
        ball.GetComponent<Ball>().Reset();
        player1Paddle.GetComponent<Paddle>().Reset();
        player2Paddle.GetComponent<Paddle>().Reset();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseMenu.gameObject.activeSelf)
            {
                pauseMenu.gameObject.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                pauseMenu.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
        }

    }
      public void LoadScenes(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }

    public void Quit()
    {
        Application.Quit();
    }   


     public void ResumeGame ()
        {
            pauseMenu.gameObject.SetActive(false);
            Time.timeScale = 1;
        }


   
}
   


