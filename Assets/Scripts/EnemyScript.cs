using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    public GameObject gameOverUI;   // The game over UI game object

    private void OnDestroy()
    {
        if (gameObject.name == "EnemyToDestroy")
        {
            Time.timeScale = 0f;    // Stop the game
            gameOverUI.SetActive(true);   // Turn on the game over UI
        }
    }
}