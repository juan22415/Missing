using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightrotation : MonoBehaviour {

    

    // Generate a plane that intersects the transform's position with an upwards normal.
    
    // Use this for initialization
    void Start () {
        
        // Generate a ray from the cursor position
        //DebugDrawPlane(transform.position, Vector3.up);
        // Determine the point where the cursor ray intersects the plane.
        // This will be the point that the object must look towards to be looking at the mouse.
        // Raycasting to a Plane object only gives us a distance, so we'll have to take th

    }

    // Update is called once per frame
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
            
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 10 * Time.deltaTime);
            transform.eulerAngles = new Vector3(90, transform.eulerAngles.y, transform.eulerAngles.z);
        }    
    }

   
}
