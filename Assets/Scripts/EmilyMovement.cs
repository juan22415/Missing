using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmilyMovement : MonoBehaviour {

    [SerializeField]
    private GameObject[] dasheffect;
    private float horizontalmove, verticalmove;
    private Rigidbody emily_rigidbody;
    private float dashCooldown=3;
    private float dashduration=1f;
    private bool candash=true;

    public float speed;
    public float dashforce;


    public Dash dash;


    void Start () {

        emily_rigidbody = GetComponent<Rigidbody>();
	}

    void Update()
    {
        if (!candash)
        {
            dashCooldown -= Time.deltaTime;
        }

        if (dashCooldown<0)
        {
            candash = true;
            dash.Enabler();
        }

        if (dashduration < 1)
        {
            Dash();
        }

        horizontalmove = Input.GetAxis("Horizontal");
        verticalmove = Input.GetAxis("Vertical");

        emily_rigidbody.velocity = new Vector3(horizontalmove * speed, 0, verticalmove * speed);

        if (Input.GetMouseButtonDown(1) && candash)
        {
            Dash();
        }
    } 
    public void Dash()
    {
        emily_rigidbody.AddForce(emily_rigidbody.velocity.normalized * dashforce);

        dash.Disabler();
        candash = false;
        dashCooldown = 1f;
        dashduration -= Time.deltaTime;

        if (dashduration < 0) dashduration = 1;
    }
    
         
}
