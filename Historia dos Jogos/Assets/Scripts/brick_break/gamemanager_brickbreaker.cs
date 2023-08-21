using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamemanager_brickbreaker : MonoBehaviour
{
     [Header("Score UI")]
    public GameObject ScoreText;
    public GameObject LivesText;

    private int Score;
    public int Lives;
     
     [Header("Pause Menu")]
     public GameObject pauseMenu; 
   

    public void LoadScenes(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }

     public void Quit()
    {
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {
        LivesText.GetComponent<TextMeshProUGUI>().text = Lives.ToString();
        ScoreText.GetComponent<TextMeshProUGUI>().text = Score.ToString();
    }


    // Update is called once per frame
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
        public void ResumeGame ()
        {
            pauseMenu.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
}

    
