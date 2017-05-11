using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class valve : MonoBehaviour
{

    [SerializeField]
    private GameObject fire;
    private ParticleSystem fireparticles;
    [SerializeField]
    private Light flame_light;
    private float decreasetime = 2;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            fireparticles = fire.GetComponent<ParticleSystem>();
            fireparticles.Stop();
            Lightdecreaser();
            fire.GetComponent<BoxCollider>().enabled = false;
        }

    }

    private void Lightdecreaser()
    {
        while (flame_light.intensity > 0)
        {
            flame_light.intensity = Mathf.Lerp(15.4f, 0, decreasetime / Time.deltaTime);
        }
    }
}
