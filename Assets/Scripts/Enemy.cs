using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Enemy : MonoBehaviour
{
    public Animator animator;
    public float speed = 3f;
    public Transform target;
    //enemy health stuff
    public int maxHealth = 100;
    int currentHealth;
 
    void Start()
    {
        currentHealth = maxHealth;
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
       
        Destroy(gameObject);
    }
 
    private void Update() {
        if (target != null){
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, target.position, step);
        }
    }
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "Player"){
            target = other.transform;
        }
    }
    private void OnTriggerExit2D(Collider2D other){
        if (other.gameObject.tag == "Player"){
            target = null;
        }
    }
   
}
