using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bossvalve : MonoBehaviour {

    public BossHealth bosshealth;
    public int valveindex;
    public AudioClip clip;
    public AudioSource source;


    private void Start()
    {
        source = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            bosshealth.valve[valveindex] = true;
            source.clip = clip;
            source.volume = 0.5f;
            source.Play();

            
        }
    }
}
