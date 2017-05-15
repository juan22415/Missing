using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_animation : MonoBehaviour {

    private Rigidbody rigidbody;
    private Animator animator;
    private Transform transform;
    Vector3 theScale;

    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        transform = GetComponent<Transform>();
        Vector3 theScale = transform.localScale;

    }
	
	// Update is called once per frame
	void Update () {

        Debug.Log(rigidbody.velocity);

        if (rigidbody.velocity.x>0 && rigidbody.velocity.y > 0)
        {
            animator.SetBool("movingfront", false);
            theScale.x = 1;
            transform.localScale = theScale;
        }

        else if (rigidbody.velocity.x > 0 && rigidbody.velocity.y < 0)
        {
            animator.SetBool("movingfront", true);
            theScale.x = 1;
            transform.localScale = theScale;
        }

        else if (rigidbody.velocity.x < 0 && rigidbody.velocity.y > 0)
        {
            animator.SetBool("movingfront", false);
            theScale.x = -1;
            transform.localScale = theScale;
        }

        else if (rigidbody.velocity.x < 0 && rigidbody.velocity.y < 0)
        {
            animator.SetBool("movingfront", true);
            theScale.x = -1;
            transform.localScale = theScale;
        }

    }
}
