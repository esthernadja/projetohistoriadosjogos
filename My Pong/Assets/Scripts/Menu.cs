using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void LoadScenes(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
