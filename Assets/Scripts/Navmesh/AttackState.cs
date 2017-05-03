using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : BearStateBase

{

    public AttackState(BearAIController controlled) : base(controlled)
    {
    }

    public override void UpdateState()
    {
        Search();

    }
    public override void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AttackEmily();
            Search();
        }

    }
    private void AttackEmily()
    {
        controlled.Disparar();


    }
    private void Search()
    {
        Transform player = LookForPlayer();
        if (player != null)
            ToChase(player);
    }

    private void ToPatrol()
    {
        controlled.MakeTransition(BearState.Patrol);
    }
    private void ToChase(Transform player)
    {
        controlled.chaseTarget = player;
        controlled.MakeTransition(BearState.Chase);
    }
}

