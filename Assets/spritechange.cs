using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spritechange : MonoBehaviour {

    public Sprite[] spritearray;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.localEulerAngles.y > 345 || transform.localEulerAngles.y < 15)
        {
            GetComponent<SpriteRenderer>().sprite = spritearray[4];
        }

        if (transform.localEulerAngles.y > 15 && transform.localEulerAngles.y < 60)
        {
            GetComponent<SpriteRenderer>().sprite = spritearray[3];
        }
        if (transform.localEulerAngles.y > 60 && transform.localEulerAngles.y < 165)
        {
            GetComponent<SpriteRenderer>().sprite = spritearray[2];
        }
        if (transform.localEulerAngles.y > 165 && transform.localEulerAngles.y < 195)
        {
            GetComponent<SpriteRenderer>().sprite = spritearray[1];
        }
        if (transform.localEulerAngles.y > 195 && transform.localEulerAngles.y < 300)
        {
            GetComponent<SpriteRenderer>().sprite = spritearray[6];
        }
        if (transform.localEulerAngles.y > 300 && transform.localEulerAngles.y < 345)
        {
            GetComponent<SpriteRenderer>().sprite = spritearray[5];
        }

    }
}
