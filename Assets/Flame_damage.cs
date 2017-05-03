using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flame_damage : MonoBehaviour {


    GameObject player;
    PlayerHealth playerHealth;
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
        
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerStay(Collider other)
    {
        playerHealth.TakeDamage(2);
    }
}
