using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public Rigidbody Rig;
    public float Velocidade = 2f;

    public GameControler gameControler;

    void Start()
    {
        Rig.velocity = Vector3.down * Velocidade;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("fim") == true)
        {
            gameControler.GameOver();
            
        }
    }
}
