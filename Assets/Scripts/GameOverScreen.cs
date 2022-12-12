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
        GameManager.manager.playerHealth = GameManager.manager.playerMaxHealth;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ExitButton() {
        SceneManager.LoadScene("menu");
    }
}
