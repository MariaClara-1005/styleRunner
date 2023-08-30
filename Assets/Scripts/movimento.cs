using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    public Rigidbody rig;

    public float Velocidade;

    public GameControler gameControler;

    void Start()
    {
        rig.velocity = Vector3.left * Velocidade;
    }

    void FixedUpdate()
    {

    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player") == true)
        {
            gameControler.GameOver();
            
        }
    }
}
