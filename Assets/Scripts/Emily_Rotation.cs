using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emily_Rotation : MonoBehaviour {


    private bool facingright = true;
    private Rigidbody emily_rigidbody;
    [SerializeField]
    private GameObject flashlight;
    public Animator anim;



    // Use this for initialization
    void Awake ()
    {
        emily_rigidbody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {

        //Debug.Log(flashlight.transform.localEulerAngles.y);

        if (flashlight.transform.localEulerAngles.y > 345 || flashlight.transform.localEulerAngles.y < 15)
        {
            anim.SetInteger("direction", 4);
        }

        else if (flashlight.transform.localEulerAngles.y > 15 && flashlight.transform.localEulerAngles.y < 60)
        {
            anim.SetInteger("direction", 3);
        }

        else if (flashlight.transform.localEulerAngles.y > 60 && flashlight.transform.localEulerAngles.y < 165)
        {
            anim.SetInteger("direction", 2);
        }

        else if (flashlight.transform.localEulerAngles.y > 165 && flashlight.transform.localEulerAngles.y < 195)
        {
            anim.SetInteger("direction", 1);
        }

        else if (flashlight.transform.localEulerAngles.y > 195 && flashlight.transform.localEulerAngles.y < 300)
        {
            anim.SetInteger("direction", 6);
        }

        else if (flashlight.transform.localEulerAngles.y > 300 && flashlight.transform.localEulerAngles.y < 345)
        {
            anim.SetInteger("direction", 5);
        }
    }
}
