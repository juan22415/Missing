using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_actions : MonoBehaviour {

    public GameObject opener;


    private void Update()
    {
        if (Input.GetButtonDown("Y"))
        {
            opener.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("llave"))
        {
            Destroy(other.gameObject);
            opener.SetActive(true);
            
        }
    }
}
