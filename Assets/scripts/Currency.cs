using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
public class Currency : MonoBehaviour
{
    //  public GetHighScore GetHighScore;
    ShopManagerScript ShopManagerScript;
    Game_Manager Script;
    public int Coins;
    public string coinString;
    public GameObject currencyUI;
    public GameObject CoinsUI;
    public float HighScore;
    int ReSaveCounter;
    public float Score;
    float Timing;
    string Scores;
    public int TotalCoins;
    public int TotalityCoins;
    bool test;
    float Localtime;
    int framecount;
    bool DataExists;
    public int Debt;
    public int Balance;
    public float multiplier = 1;

    // Start is called before the first frame update
    void Start()
    {

        if (PlayerPrefs.GetInt("DataExists") != 1)
        {

            PlayerPrefs.SetInt("DataExists", 1);
            SaveSystem.SaveCurrency(this);
            Debug.Log("Created Datafile.");
        }


        PlayerData data = SaveSystem.LoadCurrency();
        Balance = data.totalCoins - data.Debt;
        Debt = data.Debt;
        multiplier = data.multiplier;
        if (data.multiplier < 1){
            multiplier = 1;
        }
        SaveTotalCoinData();
        if (SceneManager.GetActiveScene().name == "GameScene")
        {
            Script = GameObject.FindWithTag("GameController").GetComponent<Game_Manager>();
        }
        Localtime = Time.time;
        //currencyUI = GameObject.Find("Currency");
        test = true;
        // SaveSystem.SaveCurrency(this);

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "GameScene")
        {
            // if (SceneManager.GetActiveScene().name == "GameScene")
            Timing = Time.time - Localtime;
            //Timing = Timing * 10;
            //  float timing2 = Mathf.Pow(Timing, 2);


            /*      This line calculates the score, takes (coins+1) * tan^-1* GAMETIME/100 * 50
                    So score is always dependent on player collecting coins, otherwise the score stagnates exponentially.
            */
            Score = Mathf.Pow((Coins + 1), 1.4f) * (Mathf.Pow(Timing, 0.6f) * multiplier);

            coinString = Coins.ToString();
            currencyUI.GetComponent<Text>().text = Score.ToString("0");
            CoinsUI.GetComponent<Text>().text = Coins.ToString("0");

            if (Score > HighScore)
            {
                HighScore = Score;
            }

            if (Coins < 0)
            {
                Coins = 0;
            }
            Script.ReportAchivements(Mathf.RoundToInt(Score));
            //Debug.Log(Score);
        }
        //          PlayerData data = SaveSystem.LoadCurrency();
        //         SaveSystem.SaveCurrency(this);

        //PlayerData data = SaveSystem.LoadCurrency();
        /*
            if(framecount >= 60)
            {
                SaveSystem.SaveCurrency(this);
                framecount = 0;
                Debug.Log("Saved the game!");
            }

                framecount = framecount + 1;
          
        */
        else if (SceneManager.GetActiveScene().name == "Store")
        {

        }

    }


    public void SaveTotalCoinData()
    {
        PlayerData data = SaveSystem.LoadCurrency();
        if (data.HighScore > HighScore)
        {
            HighScore = data.HighScore;
            Debug.Log("Highscore not set!");
        }
        else
        {
            data.HighScore = HighScore;
            Debug.Log("Highscore set!");
        }

        
        //  TotalCoins = data.totalCoins;
        Debug.Log(Debt);
        TotalCoins = data.totalCoins + Coins;
        SaveSystem.SaveCurrency(this);
        //PlayerData dataa = SaveSystem.LoadCurrency();
        //Debug.Log(dataa.totalCoins);

    }
    public void Purchase(int price)
    {

        PlayerData data = SaveSystem.LoadCurrency();
        if (data.Balance >= price)
        {
            Debug.Log("purchase");
            Debt = data.Debt + price;
            Balance = data.totalCoins - Debt;
            SaveTotalCoinData();
        }
        else
        {
            Debug.Log("no money");
        }
    }
    public void purchaseTwoMultiplier()
    {
        multiplier = multiplier + 0.2f;
        if (multiplier >= 2){
            multiplier = 2;
        }
            SaveTotalCoinData();
    }
    public void UpdateBalance()
    {
        PlayerData data = SaveSystem.LoadCurrency();
        Balance = data.totalCoins - Debt;
        SaveTotalCoinData();
        Debug.Log(multiplier);
    }
    public void NerfBoosters()
    {
        if (multiplier >= 2)
        {
            multiplier = 1 + multiplier / 10f;
            if (multiplier >= 2)
            {
                multiplier = 2;
            }
        }
        else if (multiplier == 0){
            multiplier=1;
        }
        SaveTotalCoinData();
    }
}