using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    Animator animator;
    public static event Action OnPlayerDeath;
    public HealthBar healthBar;
    void Start()
    {
        animator = GetComponent<Animator>();
        healthBar.SetMaxHealth(GameManager.manager.playerMaxHealth);
    }

    public void UpdateHealth(float deltaHealth)
    {
        if (deltaHealth < 0){
            animator.SetTrigger("takeDamage");
        }
        GameManager.manager.playerHealth += deltaHealth;

        healthBar.SetHealth(GameManager.manager.playerHealth);

        if (GameManager.manager.playerHealth <= 0)
        {
            GameManager.manager.playerHealth = 0;
            OnPlayerDeath?.Invoke();
        }
        else if (GameManager.manager.playerHealth >= GameManager.manager.playerMaxHealth)
        {
            GameManager.manager.playerHealth = GameManager.manager.playerMaxHealth;
        }
    }
}
