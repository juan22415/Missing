﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_actions : MonoBehaviour {

    public GameObject opener;




    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("llave"))
        {
            opener.SetActive(true);
            Destroy(other);
        }
    }
}