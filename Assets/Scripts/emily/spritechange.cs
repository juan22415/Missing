using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spritechange : MonoBehaviour {

    public Sprite[] spritearray;
    
	
	// Update is called once per frame
	void Update () {

        if (RotationManager.Instance.rot_direction==4)
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
