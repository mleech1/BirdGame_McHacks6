using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bird : MonoBehaviour 
{
    public float upForce = 350f;
    public float sideForce = 100f;                   //Upward force of the "flap".
    private bool isRight = true;            //Has the player collided with a wall?

    //private Animator anim;                  //Reference to the Animator component.
    private Rigidbody2D rb2d;               //Holds a reference to the Rigidbody2D component of the bird.

    void Start()
    {
        //Get reference to the Animator component attached to this GameObject.
        //anim = GetComponent<Animator> ();
        //Get and store a reference to the Rigidbody2D attached to this GameObject.
        rb2d = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        isRight = !isRight;
        rb2d.velocity = Vector2.zero;

        if (isRight)
        {
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(new Vector2(sideForce, upForce));
        }

        if (!isRight)
        {
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(new Vector2(-sideForce, upForce));
        }

        }

    void Update()
    {
        //Don't allow control if the bird has died.
        if (isRight == true) 
        {
            //Look for input to trigger a "flap".
            if (Input.GetKeyDown("a")) 
            {
                //...tell the animator about it and then...
                //anim.SetTrigger("Flap");
                //...zero out the birds current y velocity before...
                rb2d.velocity = Vector2.zero;
                //  new Vector2(rb2d.velocity.x, 0);
                //..giving the bird some upward force.
                rb2d.AddForce(new Vector2(sideForce, upForce));
            }
        } else
        {
            if (Input.GetKeyDown("a"))
            {
                //...tell the animator about it and then...
                //anim.SetTrigger("Flap");
                //...zero out the birds current y velocity before...
                rb2d.velocity = Vector2.zero;
                //  new Vector2(rb2d.velocity.x, 0);
                //..giving the bird some upward force.
                rb2d.AddForce(new Vector2(-sideForce, upForce));
            }

        }
    }
}
