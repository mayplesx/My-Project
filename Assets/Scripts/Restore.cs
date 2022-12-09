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
            Debug.Log("itai!");
            playerHealth = collider.gameObject.GetComponent<PlayerHealth>();
            playerHealth.UpdateHealth(1);
            Destroy(gameObject);
        }
    }
}
