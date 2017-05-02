using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmilyMovement : MonoBehaviour {

    [SerializeField]
    private GameObject[] dasheffect;
    private float horizontalmove, verticalmove;
    private Rigidbody emily_rigidbody;
    private float dashtimer=3;
    private bool candash=true;


    public Dash dash;
    


    void Start () {

        emily_rigidbody = GetComponent<Rigidbody>();
	}

    void Update()
    {
        if (!candash)
        {
            dashtimer -= Time.deltaTime;
        }

        if (dashtimer<0)
        {
            candash = true;
            dash.Enabler();
        }

        horizontalmove = Input.GetAxis("Horizontal");
        verticalmove = Input.GetAxis("Vertical");

        emily_rigidbody.velocity = new Vector3(horizontalmove * 4, 0, verticalmove * 4);

        if (Input.GetMouseButtonDown(1) && candash)
        {

            emily_rigidbody.AddForce(new Vector3(horizontalmove, 0, verticalmove)*30,ForceMode.VelocityChange);
            dash.Disabler();
            candash = false;
            dashtimer = 1f;
        }
    }      
}
