using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationManager : GenericSingletonClass<RotationManager>
{

    public int rot_direction;
	void Update () {

        if (transform.localEulerAngles.y > 345| transform.localEulerAngles.y < 15)
        {
            rot_direction = 4;

        }

        if (transform.localEulerAngles.y > 25 && transform.localEulerAngles.y < 60)
        {
            rot_direction = 3;

        }
        if (transform.localEulerAngles.y > 70 && transform.localEulerAngles.y < 160)
        {
            rot_direction = 2;

        }
        if (transform.localEulerAngles.y > 170 && transform.localEulerAngles.y < 195)
        {
            rot_direction = 1;

        }
        if (transform.localEulerAngles.y > 205 && transform.localEulerAngles.y < 290)
        {
            rot_direction = 6;

        }
        if (transform.localEulerAngles.y > 300 && transform.localEulerAngles.y < 335)
        {
            rot_direction = 5;

        }

    }
}
