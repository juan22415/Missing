using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableObject : MonoBehaviour
{

    public GameObject toenable;
    public AudioSource source;
    public AudioClip clip;



    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))

        {
            toenable.SetActive(true);
            source.clip = clip;
            source.Play();
        }
    }
}
