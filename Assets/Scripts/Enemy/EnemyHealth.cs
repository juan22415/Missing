using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public float currentHealth;
    public float sinkSpeed = 2.5f;
    public int scoreValue = 10;
    public AudioClip deathClip;


    Animator anim;
    AudioSource enemyAudio;
   public ParticleSystem hitParticles;
    BoxCollider boxcollider;
    bool isDead;
    bool isSinking;


    void Awake()
    {
        anim = GetComponent<Animator>();
        enemyAudio = GetComponent<AudioSource>();
       
        boxcollider = GetComponent<BoxCollider>();

        currentHealth = startingHealth;
    }


    void Update()
    {
        if (isSinking)
        {
          transform.Translate(-Vector3.up * sinkSpeed * Time.deltaTime);
        }
    }


    public void TakeDamage(float amount, Vector3 hitPoint)
    {
        if (isDead)
            return;

        enemyAudio.Play();

        currentHealth -= amount;

        //hitParticles.transform.position = hitPoint;
        hitParticles.Play();

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
        GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        isSinking = true;
        //ScoreManager.score += scoreValue;
        Destroy(gameObject, 2f);
    }


    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag=="linterna")
        {
            TakeDamage(0.2f, Vector3.zero);
        }
    }
}

