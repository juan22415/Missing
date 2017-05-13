using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmilyMovement : MonoBehaviour {

    [SerializeField]
    private GameObject[] dasheffect;
    private float horizontalmove, verticalmove;
    private Rigidbody emily_rigidbody;
    private float dashCooldown=3;
    private float dashduration= 0.5f;
    private bool candash=true;
    private Vector3 dashdirection;

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

        if (dashduration < 0.5f)
        {
            Dash();
        }

        horizontalmove = Input.GetAxis("Horizontal");
        verticalmove = Input.GetAxis("Vertical");

        emily_rigidbody.velocity = new Vector3(horizontalmove * speed, 0, verticalmove * speed);

        if (Input.GetButtonDown("LB") && candash)
        {
            Debug.Log("LB");    
            Dash();
            dashdirection= emily_rigidbody.velocity.normalized;
        }

    } 
    public void Dash()
    {
        emily_rigidbody.AddForce(dashdirection * dashforce,ForceMode.Impulse);

        dash.Disabler();
        candash = false;
        dashCooldown = 1f;
        dashduration -= Time.deltaTime;

        if (dashduration < 0) dashduration = 0.5f;
    }
    
         
}
