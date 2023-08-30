using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriadorObstaculos : MonoBehaviour
{
    public GameObject obstaculo;


    public float xMin = -3.6f;
    public float xMax = 38f;
    public float yMin = -13.6f;
    public float yMax = -1f;
    public float zMin = -15.1f;
    public float zMax = -7f;

    public float Espera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Espera -= Time.deltaTime;

        if (Espera <= 0)
        {
            Vector3 posicao = new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), Random.Range(zMin, zMax));
            Instantiate(obstaculo, posicao, Quaternion.identity);

            Espera = 5;
        }

    }
}
