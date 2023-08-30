using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiro : MonoBehaviour
{
    public float VelocidadeTiro = 10f;
    public Rigidbody Rig;

    // Start is called before the first frame update
    void Start()
    {
        Rig.velocity = Vector3.right * VelocidadeTiro;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collison)
    {
        if(collison.gameObject.tag == "inimigo")
        {
            Placar.instance.UpdateScore();
            Destroy(collison.gameObject);
            Destroy(gameObject);
        }

    }
}
