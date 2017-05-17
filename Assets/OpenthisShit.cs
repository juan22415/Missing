using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenthisShit : MonoBehaviour
{
    private Animator animator;
    private AudioSource source;

    public AudioClip clip;
    public GameObject text;


    private void Start()
    {
        animator = GetComponent<Animator>();
        source = GetComponent<AudioSource>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        text.SetActive(true);
    }

    private void OnCollisionExit(Collision collision)
    {
        text.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("opener"))
        {
            Destroy(text);
            animator.SetBool("havekey", true);
            source.clip = clip;
            source.Play();
        }

    }

}
