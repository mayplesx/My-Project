using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public GameObject gameOverScreen;
    private void OnEnable()
    {
        PlayerHealth.OnPlayerDeath += EnableGameOverScreen;
    }
    private void OnDisable()
    {
        PlayerHealth.OnPlayerDeath -= EnableGameOverScreen;
    }
    public  void EnableGameOverScreen()
    {
        gameOverScreen.SetActive(true);
    }
    public void RestartButton() {
        SceneManager.LoadScene("frog test");
    }
    public void ExitButton() {
        SceneManager.LoadScene("menu");
    }
}
