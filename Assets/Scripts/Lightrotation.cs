using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightrotation : MonoBehaviour {

    [SerializeField]
    private GameObject[] hands;

    void Update () {
        
        Plane playerPlane = new Plane(Vector3.up, transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitdist = 0.0f;
        // If the ray is parallel to the plane, Raycast will return false.
        if (playerPlane.Raycast(ray, out hitdist))
        {
            // Get the point along the ray that hits the calculated distance.
            Vector3 targetPoint = ray.GetPoint(hitdist);
            //Debug.Log(targetPoint);
            Debug.DrawLine(transform.position, targetPoint, Color.blue);
            // Determine the target rotation.  This is the rotation if the transform looks at the target point.
            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
            // Smoothly rotate towards the target point.
            
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 20 * Time.deltaTime);
            transform.eulerAngles = new Vector3(90, Mathf.Round(transform.eulerAngles.y), Mathf.Round(transform.eulerAngles.z));

            if (RotationManager.Instance.rot_direction == 4)
            {
                transform.position = hands[4].transform.position;

            }

            if (RotationManager.Instance.rot_direction == 3)
            {
                transform.position = hands[3].transform.position;

            }
            if (RotationManager.Instance.rot_direction == 2)
            {
                transform.position = hands[2].transform.position;

            }
            if (RotationManager.Instance.rot_direction == 1)
            {
                transform.position = hands[1].transform.position;

            }
            if (RotationManager.Instance.rot_direction == 6)
            {
                transform.position = hands[6].transform.position;

            }
            if (RotationManager.Instance.rot_direction == 5)
            {
                transform.position = hands[5].transform.position;

            }



        }    
    }

   
}
