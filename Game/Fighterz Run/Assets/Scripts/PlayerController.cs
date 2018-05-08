using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    public float moveSpeed;
    public float jumpForce;

    private Rigidbody2D myRigidbody;

    public bool grounded;
    public LayerMask whatIsground;

    private Collider2D myCollider;

    private Animator myAnimatior;


	// Use this for initialization
	void Start () {
        myRigidbody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
        myAnimatior = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        grounded = Physics2D.IsTouchingLayers(myCollider, whatIsground);

        

        myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButtonDown(0))
        {
            //remove if(grounded){} but keep the code in statement to have infinte jumps
            if (grounded)
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
            }

        }
        myAnimatior.SetFloat("Speed", myRigidbody.velocity.x);
        myAnimatior.SetBool("Grounded", grounded);
	}
}
