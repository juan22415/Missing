using UnityEngine;
using System.Collections;

namespace CompleteProject
{
    public class EnemyMovement : MonoBehaviour
    {
        Transform player;               // Reference to the player's position.
        PlayerHealth playerHealth;      // Reference to the player's health.
        EnemyHealth enemyHealth;        // Reference to this enemy's health.
        UnityEngine.AI.NavMeshAgent nav;               // Reference to the nav mesh agent.
        Vector3 targetdirection;
        Animator animator;
        Vector3 myscale;


        public int scalesize;



        void Awake ()
        {
            // Set up the references.
            player = GameObject.FindGameObjectWithTag ("Player").transform;
            playerHealth = player.GetComponent <PlayerHealth> ();
            enemyHealth = GetComponent <EnemyHealth> ();
            nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
            animator = GetComponent<Animator>();
            Vector3 myscale = (new Vector3(1, 1, 1));
        }

        private void FixedUpdate()
        {
            targetdirection = player.position - transform.position;

            if (targetdirection.x > 0)
            {
                animator.SetBool("movingright", true);
                Vector3 myscale = (new Vector3(scalesize, scalesize, 1));
                transform.localScale = myscale;
            }
            else
            { 
                animator.SetBool("movingright", false);
                Vector3 myscale = (new Vector3(-scalesize, scalesize, 1));
                transform.localScale = myscale;

            }

            if (targetdirection.z > 0)
            {
                animator.SetBool("movingfront", false); 
            }

            else animator.SetBool("movingfront",true );

        }
        void Update ()
        {
            nav.updateRotation = false;
            // If the enemy and the player have health left...
            if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
            {
                // ... set the destination of the nav mesh agent to the player.
                nav.SetDestination (player.position);
            }
            // Otherwise...
            else
            {
                // ... disable the nav mesh agent.
                nav.enabled = false;
            }
        }
    }
}