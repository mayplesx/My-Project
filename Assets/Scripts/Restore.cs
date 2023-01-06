using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restore : MonoBehaviour
{
    PlayerHealth playerHealth;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            playerHealth = collider.gameObject.GetComponent<PlayerHealth>();
            playerHealth.UpdateHealth(25);
            Destroy(gameObject);
        }
    }
}
