using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emily_Rotation : MonoBehaviour {


    private bool facingright = true;
    private Rigidbody emily_rigidbody;
    [SerializeField]
    private GameObject flashlight;



    // Use this for initialization
    void Awake ()
    {
        emily_rigidbody = GetComponent<Rigidbody>();	
	}
	
	// Update is called once per frame
	void Update () {

       // Debug.Log(flashlight.transform.localEulerAngles);

        if (emily_rigidbody.velocity.x > 0 && !facingright)
        {
            flip();
        }
        else if (emily_rigidbody.velocity.x < 0 && facingright)
        {
            flip();
        }

        else if (flashlight.transform.localEulerAngles.y > 0 && flashlight.transform.localEulerAngles.y < 180)
        {
            Debug.Log("mirando a la derecha");
        }

        else if (flashlight.transform.localEulerAngles.y > 180 && flashlight.transform.localEulerAngles.y < 360)
        {
            Debug.Log("mirando a la izquierda");
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
