using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmilyMovement : MonoBehaviour {
    private float horizontalmove, verticalmove;
    private Rigidbody emily_rigidbody;
    public bool facingright = true;
    public TrailRenderer trail;

    void Start () {

        emily_rigidbody = GetComponent<Rigidbody>();
        trail = GetComponent<TrailRenderer>();
        trail.enabled = false;
	}

	void Update () {

        horizontalmove = Input.GetAxis("Horizontal");
        verticalmove = Input.GetAxis("Vertical");

        emily_rigidbody.velocity = new Vector3(horizontalmove * 4, 0, verticalmove * 4);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            emily_rigidbody.AddForce(new Vector3(horizontalmove, 0, verticalmove)*1000);
            trail.enabled = true;
        } 

        if (horizontalmove > 0 && !facingright)
        {
            flip();
        }
        else if (horizontalmove < 0 && facingright)
        {
            flip();
        }
    }

    void flip()
    {

        facingright = !facingright;
        Vector3 myscale = transform.localScale;
        myscale.x *= -1;
        transform.localScale = myscale;
    }
}
