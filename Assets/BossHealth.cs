using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BossHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public float currentHealth;
    public float sinkSpeed = 2.5f;
    public int scoreValue = 10;
    public AudioClip deathClip;
    public AudioClip takingdamage;
    public AudioClip laugh;


    Animator anim;
    AudioSource enemyAudio;
    //public ParticleSystem hitParticles;
    BoxCollider boxcollider;
    bool isDead;
    bool isSinking;
    bool cantakedamage;
    int phasechangehealth=400;

    public bool[] valve;




    void Awake()
    {
        anim = GetComponent<Animator>();
        enemyAudio = GetComponent<AudioSource>();

        boxcollider = GetComponent<BoxCollider>();

        currentHealth = startingHealth;
        valve[0] = false;
        valve[1] = false;
    }


    void Update()
    {
        if (isSinking)
        {
            transform.Translate(-Vector3.up * sinkSpeed * Time.deltaTime);
        }


        if (valve[0]==true && valve[1]==true)
        {
            cantakedamage = true;
        }

        if (cantakedamage)
        {
            anim.SetBool("cantakedamage", true);
        }
    }


    public void TakeDamage(float amount, Vector3 hitPoint)
    {
        if (isDead)
            return;

        enemyAudio.Play();

        currentHealth -= amount;


        if (currentHealth< phasechangehealth)
        {
            valve[0] = false;
            valve[1] = false;
            anim.SetBool("cantakedamage", false);
            cantakedamage = false;
            phasechangehealth -= 200;

        }

        //hitParticles.transform.position = hitPoint;
        //hitParticles.Play();

        if (currentHealth <= 0)
        {
            Death();
        }
    }


    void Death()
    {
        isDead = true;

        boxcollider.isTrigger = true;

        //  anim.SetTrigger("Dead");

        enemyAudio.clip = deathClip;
        enemyAudio.Play();
        StartSinking();

    }


    public void StartSinking()
    {
        //GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        isSinking = true;
        //ScoreManager.score += scoreValue;
        Destroy(gameObject, 2f);
    }

    public void playdamagesound()
    {
        if (!enemyAudio.isPlaying)
        {
            //enemyAudio.volume = 0.2f;
            enemyAudio.PlayOneShot(takingdamage, 1);
        }

    }


    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "linterna")
        {

            if (cantakedamage)
            {
                playdamagesound();
                TakeDamage(0.2f, Vector3.zero);
            }

            else
            {
                playlaughsound();
            }

        }
    }

    private void playlaughsound()
    {
        if (!enemyAudio.isPlaying)
        {
           
            enemyAudio.PlayOneShot(laugh, 1);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "linterna")
        {
            if (!isDead)
                enemyAudio.Stop();

        }
    }
}

