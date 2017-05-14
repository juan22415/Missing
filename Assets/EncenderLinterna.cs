using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncenderLinterna : MonoBehaviour {

    [SerializeField]
    private Light flashlight;
    private BoxCollider collider;

    private bool isenabled;

    private float overheat;

	void Start () {
        collider = GetComponent<BoxCollider>();
	}

	void Update () {
        Debug.Log(overheat);

        if (isenabled == true)
        {
            overheat+=0.2f;
            if (overheat > 100)
            {
                Changer(false);
            }
        }
        else
        {
            overheat-=0.5f;
            if (overheat <= 0) overheat = 0;
        }


		if (Input.GetButtonDown("RB"))
        {
            if (isenabled) Changer(false);

            else Changer(true);       
        }
	}


    public void Changer(bool state)
    {
        flashlight.enabled = state;
        collider.enabled = state;
        isenabled = state;
    }
}
