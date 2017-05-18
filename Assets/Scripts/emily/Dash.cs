using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour {

    [SerializeField]
    private Sprite[] spritearray;
    [SerializeField]
    private GameObject emily;
    private bool enabler=true;
    private bool active= false;
    

    // Update is called once per frame
    void Update () {

        if (emily==null)
        {
            Destroy(gameObject);
        } 

        if(active==false)
        {
            transform.position = emily.transform.position;
        }


        if (enabler==true)
        { 

        if (RotationManager.Instance.rot_direction == 4)
        {
            GetComponent<SpriteRenderer>().sprite = spritearray[4];
        }

        if (RotationManager.Instance.rot_direction == 3)
        {
            GetComponent<SpriteRenderer>().sprite = spritearray[3];
        }
        if (RotationManager.Instance.rot_direction == 2)
        {
            GetComponent<SpriteRenderer>().sprite = spritearray[2];
        }
        if (RotationManager.Instance.rot_direction == 1)
        {
            GetComponent<SpriteRenderer>().sprite = spritearray[1];
        }
        if (RotationManager.Instance.rot_direction == 6)
        {
            GetComponent<SpriteRenderer>().sprite = spritearray[6];
        }
        if (RotationManager.Instance.rot_direction == 5)
        {
            GetComponent<SpriteRenderer>().sprite = spritearray[5];
        }

        }
    }


    public void Enabler ()
    {
        enabler = true;
        active = false;
    }
    public void Disabler()
    {
        enabler = false;
        active = true;
    }
}
