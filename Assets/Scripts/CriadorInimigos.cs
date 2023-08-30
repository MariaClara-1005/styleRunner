using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriadorInimigos : MonoBehaviour
{
    public GameObject inimigo;

    //onde vai gerar os inimigos
    public float xMin = -17.3f;
    public float xMax = 25.5f;
    public float yMin = 18.8f;
    public float yMax = 24.3f;
    public float zMin = -9f;
    public float zMax = -11.2f;

    //em qual tempo
    public float Espera = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Espera -= Time.deltaTime;

        if(Espera <= 0)
        {
            Vector3 posicao = new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), Random.Range(zMin, zMax));
            Instantiate(inimigo, posicao, Quaternion.identity);

            Espera = 5;
        }
    }
}
