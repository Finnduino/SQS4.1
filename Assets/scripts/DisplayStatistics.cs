using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayStatistics : MonoBehaviour
{
    public GameObject AllCoins;
    public GameObject Highscore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerData data = SaveSystem.LoadCurrency();
        AllCoins.GetComponent<Text>().text = data.totalCoins.ToString();
        Highscore.GetComponent<Text>().text = data.HighScore.ToString("0");

    }
}
