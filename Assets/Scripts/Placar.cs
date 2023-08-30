using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Placar : MonoBehaviour
{
    public Text scoreTxt;
    private int score;

    private int TotalScore;

    public static Placar instance;
    // Start is called before the first frame update
    void Start()
    {
        
        instance = this;
        TotalScore = PlayerPrefs.GetInt("Ponto");
    }

    // Update is called once per frame
    void Update()
    {
        //scoreTxt.text = score.ToString();
    }

    public void UpdateScore()
    {
        score++;
        scoreTxt.text = TotalScore.ToString();

        TotalScore++;

        PlayerPrefs.SetInt("Ponto", TotalScore);
    }
   
}
