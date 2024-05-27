using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameWonUI;
    public float restartGameDelay = 1f;
    Boolean gameHasEnded = false;
    public void EndGame()
    {
        if (!gameHasEnded)
        {
        Debug.Log("Game Over...");
        gameHasEnded = true;
            Invoke("Restart", restartGameDelay);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void WinGame()
    {
        gameWonUI.SetActive(true);
    }
}
