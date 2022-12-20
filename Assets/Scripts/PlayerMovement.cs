using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;

    Animator animator;

    public float runSpeed = 20.0f;
    public bool canMove;



    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        canMove = true;

        animator = GetComponent<Animator>();

        animator.SetBool("isWalking", false);
        animator.SetFloat("animHorizontal",1);


    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (horizontal == 0 && vertical == 0)
        {
            animator.SetBool("isWalking", false);
        }
        else
        {
            animator.SetBool("isWalking", true);
            animator.SetFloat("animHorizontal",horizontal);
            animator.SetFloat("animVertical", vertical);
        }
    }

    void FixedUpdate()
    {
        if (DialogueManager.GetInstance().dialogueIsPlaying)
        {
            return;
        }
        if (horizontal != 0 && vertical !=0)
        {
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }

        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }



    // Create a function that looks like Update Health

     public void UpdateSpeed(float deltaSpeed)
    {
        runSpeed += deltaSpeed;
    }
}
