using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public void SetHealth (float health)
    {
        slider.value = health;
    }

    public void SetMaxHealth (float maxHealth)
    {
        slider.maxValue = maxHealth;
        slider.value = maxHealth;
    }
    public float GetHealth()
    {
        return slider.value;
    }
}
