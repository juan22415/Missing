using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmilyMovement : MonoBehaviour
{

    [SerializeField]
    private GameObject[] dasheffect;
    private float horizontalmove, verticalmove;
    private Rigidbody emily_rigidbody;
    private float dashCooldown = 3;
    private float dashduration = 0.5f;
    private bool candash = true;
    private Vector3 dashdirection;
    private bool ismoving = false;
    private AudioSource m_audiosource;

    private float volumen;
    private float volLowRange = .10f;
    private float volHighRange = .30f;


    public float speed;
    public float dashforce;
    public AudioClip footsteps;

    public Dash dash;


    void Start()
    {

        m_audiosource = GetComponent<AudioSource>();
        emily_rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!candash)
        {
            dashCooldown -= Time.deltaTime;
        }

        if (dashCooldown < 0)
        {
            candash = true;
            dash.Enabler();
        }

        if (dashduration < 0.5f)
        {
            Dash();
        }

        horizontalmove = Input.GetAxis("Horizontal");
        verticalmove = Input.GetAxis("Vertical");

        move();

        if (Input.GetButtonDown("LB") && candash)
        {
            Debug.Log("LB");
            Dash();
            dashdirection = emily_rigidbody.velocity.normalized;
        }

    }

    public void move()
    {

        emily_rigidbody.velocity = new Vector3(horizontalmove * speed, 0, verticalmove * speed);
        if (!m_audiosource.isPlaying)
        {

            volumen = Random.Range(volLowRange, volHighRange);
            m_audiosource.clip = footsteps;
            m_audiosource.volume = volumen;
            m_audiosource.Play();

        }

        if (Mathf.Abs( emily_rigidbody.velocity.x) < 0.2 && Mathf.Abs(emily_rigidbody.velocity.z) < 0.2)
        {
            m_audiosource.Stop();
        }

    }

    public void Dash()
    {
        emily_rigidbody.AddForce(dashdirection * dashforce, ForceMode.Impulse);

        dash.Disabler();
        candash = false;
        dashCooldown = 1f;
        dashduration -= Time.deltaTime;

        if (dashduration < 0) dashduration = 0.5f;
    }


}
