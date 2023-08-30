using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControler : MonoBehaviour
{
    void Start()
    {
        
    }
    
    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
        

    }
}
