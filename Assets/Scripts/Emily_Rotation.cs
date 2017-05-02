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

        if (RotationManager.Instance.rot_direction == 4)
        {
            anim.SetInteger("direction", 4);
        }

        else if (RotationManager.Instance.rot_direction == 3)
        {
            anim.SetInteger("direction", 3);
        }

        else if (RotationManager.Instance.rot_direction == 2)
        {
            anim.SetInteger("direction", 2);
        }

        else if (RotationManager.Instance.rot_direction == 1)
        {
            anim.SetInteger("direction", 1);
        }

        else if (RotationManager.Instance.rot_direction == 6)
        {
            anim.SetInteger("direction", 6);
        }

        else if (RotationManager.Instance.rot_direction == 5)
        {
            anim.SetInteger("direction", 5);
        }
    }
}
