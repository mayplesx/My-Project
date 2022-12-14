using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Enemy : MonoBehaviour
{
    public Animator animator;
    public float speed = 3f;
    public Transform target;
    //test
    DetectionRadius detection;
    //enemy health stuff
    public int maxHealth = 100;
    int currentHealth;
 
    void Start()
    {
        currentHealth = maxHealth;
        detection = gameObject.GetComponentInChildren<DetectionRadius>();
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
 
        //play hurt animation
        animator.SetTrigger("Hurt");
        if(currentHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        animator.SetBool("IsDead", true);
       
        Destroy(gameObject, .5f);
    }
 
    public virtual void Update() {
        if (target != null){
            float step = speed * Time.deltaTime;
            if (detection.inRange){
                transform.position = Vector2.MoveTowards(transform.position, target.position, step);
            }
        }
    }
   
}
