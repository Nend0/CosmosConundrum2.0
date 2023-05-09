using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    public void ReloadGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
