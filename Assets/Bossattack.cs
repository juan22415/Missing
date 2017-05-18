using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bossattack : MonoBehaviour {

    int attackdirection;
    Animator anim;
    float timer;


    public GameObject[] dientes;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    private void OnEnable()
    {
        attackdirection = UnityEngine.Random.Range(1, 4);

        Attack(attackdirection);
    }

    private void Attack(int attackdirection)
    {
        Debug.Log(Time.time);
        anim.SetInteger("attackdirection", attackdirection);
        StartCoroutine(waitanimation());

        //dientes[attackdirection].SetActive(false);
        Debug.Log(Time.time);


        
        GetComponent<Bossattack>().enabled = false;
        
    }


    IEnumerator waitanimation()
    {
        
        yield return new WaitForSeconds(1.7f);
        dientes[attackdirection].SetActive(true);
        anim.SetInteger("attackdirection", 0);
        StartCoroutine(waittodisable());
    }

    IEnumerator waittodisable()

    {
        yield return new WaitForSeconds(.5f);
        
        dientes[attackdirection].SetActive(false);
    }


    // Update is called once per frame
    void Update () {
		
	}
}
