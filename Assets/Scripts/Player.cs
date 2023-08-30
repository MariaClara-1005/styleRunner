using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{

    //movimentação para os lador
    public float Velocidade = 20f;
    public float zMin;
    public float zMax;

    //variaves do jummp
    public Vector3 Position;
    public float GroundCheckSize;
    public Rigidbody rig;
    public float JumpForce; //força do pulo
    public LayerMask LayerMask;
    public bool Isgrounded;


    public GameObject MeuTiro;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Movimento = transform.position;

        //Movimento.x += Input.GetAxis("Horizontal") * Velocidade * Time.deltaTime;
        Movimento.z += Input.GetAxis("Vertical") * Velocidade * Time.deltaTime;

        Movimento.z = Mathf.Clamp(Movimento.z, zMin, zMax);


        //Criando o tiro
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(MeuTiro, transform.position, transform.rotation);
        }
        //termina aqui

        //Criando o jummp
        var groundcheck = Physics.OverlapSphere(transform.position + Position, GroundCheckSize, LayerMask);

        if (groundcheck.Length != 0)
        {
            Isgrounded = true;
        }
        else
        {
            Isgrounded = false;
        }

        if (Isgrounded == true && Input.GetButtonDown("Jump"))
        {
            rig.AddForce(transform.up * JumpForce, ForceMode.Impulse);
        }
        //fim

        transform.position = Movimento;

        
    }


}
