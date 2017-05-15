using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ondestroyboss : MonoBehaviour {

    public AudioSource source;
    public AudioClip clip;

    private void OnDestroy()
    {
        source.clip = clip;
        source.Play();
    }
}
