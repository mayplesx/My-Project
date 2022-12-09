using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedBoost : MonoBehaviour
{
  PlayerMovement playerMovement;
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            Debug.Log("Ouchie!");
            playerMovement = collider.gameObject.GetComponent<PlayerMovement>();
            playerMovement.UpdateSpeed(1);
             Destroy(gameObject);
        }
    }
}
