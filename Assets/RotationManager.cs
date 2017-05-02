using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationManager : GenericSingletonClass<RotationManager>
{

    public int rot_direction;
	void Update () {

        if (transform.localEulerAngles.y > 345 || transform.localEulerAngles.y < 15)
        {
            rot_direction = 4;

        }

        if (transform.localEulerAngles.y > 15 && transform.localEulerAngles.y < 60)
        {
            rot_direction = 3;

        }
        if (transform.localEulerAngles.y > 60 && transform.localEulerAngles.y < 165)
        {
            rot_direction = 2;

        }
        if (transform.localEulerAngles.y > 165 && transform.localEulerAngles.y < 195)
        {
            rot_direction = 1;

        }
        if (transform.localEulerAngles.y > 195 && transform.localEulerAngles.y < 300)
        {
            rot_direction = 6;

        }
        if (transform.localEulerAngles.y > 300 && transform.localEulerAngles.y < 345)
        {
            rot_direction = 5;

        }

    }
}
