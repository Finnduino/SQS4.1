using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHighscore : MonoBehaviour
{
    public GameObject HighScoreUI;
    public GameObject CoinsUI;
    public GameObject ScoreUI;
    float HighScore;
    int Coins;

    // Start is called before the first frame update
    void Start()
    {
        //HighScoreUI = GameObject.Find("HighScore");
        //  CoinsUI = GameObject.Find("CoinsCollected");
        PlayerData data = SaveSystem.LoadCurrency();
        HighScoreUI.GetComponent<Text>().text = data.HighScore.ToString("0");
        CoinsUI.GetComponent<Text>().text = data.CoinsCollected.ToString("0");
        ScoreUI.GetComponent<Text>().text = data.RecentScore.ToString("0");

    }

    // Update is called once per frame
    void Update()
    {
    
    }

}
