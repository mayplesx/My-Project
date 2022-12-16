using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageRadius : MonoBehaviour
  {
    PlayerHealth playerHealth;
    [SerializeField]Animator animator;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            animator.SetTrigger("Attack");
            playerHealth = collider.gameObject.GetComponent<PlayerHealth>();
            playerHealth.UpdateHealth(-8);
        }
    }
}
