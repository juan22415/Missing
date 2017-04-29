using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class valve : MonoBehaviour {

    [SerializeField]
    private GameObject fire;
    private ParticleSystem fireparticles;
    [SerializeField]
    private Light flame_light;
    private float decreasetime = 2;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}


    private void OnTriggerEnter(Collider other)
    {
        fireparticles = fire.GetComponent<ParticleSystem>();
        fireparticles.Stop();
        Lightdecreaser();
        //flame_light.intensity= Mathf.Lerp(15.4f, 0, Time.time);
    }

    private void Lightdecreaser()
    {
        while (flame_light.intensity > 0)
        {
            flame_light.intensity = Mathf.Lerp(15.4f, 0,decreasetime/ Time.deltaTime);
        }
    }
}
