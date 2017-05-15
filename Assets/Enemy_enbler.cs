using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_enbler : MonoBehaviour
{

    public GameObject[] enemys;
    public AudioSource source;
    public AudioClip clip;


    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            source.clip = clip;
            source.Play();
            enabler();
        }
    }


    public void enabler()
    {
        Debug.Log(enemys.Length);
        

        for (int i = 0; i < enemys.Length; i++)
        {
            
            enemys[i].SetActive(true);
        }
    }

}
