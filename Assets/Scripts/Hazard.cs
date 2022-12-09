using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    PlayerHealth playerHealth;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            Debug.Log("Ouchie!");
            playerHealth = collider.gameObject.GetComponent<PlayerHealth>();
            playerHealth.UpdateHealth(-8);
        }
    }
}
