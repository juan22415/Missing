using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableObject : MonoBehaviour {

    public GameObject toenable;



    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) toenable.SetActive(true);

    }
}
