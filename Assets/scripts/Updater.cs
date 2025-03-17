using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Updater : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Updated") != 1)
        {
            PlayerData data = SaveSystem.LoadCurrency();
            Currency currency = new Currency();
            PlayerPrefs.SetInt("Updated", 1);
            Debug.Log("Vibe check has failed. Rebalancing boosters");
            currency.NerfBoosters();
        }
        else
        {
            Debug.Log("Vibe check successful");
        }
        if (PlayerPrefs.GetInt("NewHS") != 1)
        {
            PlayerPrefs.SetInt("NewHS", 1);
            PlayerData data = SaveSystem.LoadCurrency();
            Currency currency = new Currency();
            currency.HighScore = 0;
            currency.multiplier = data.multiplier;
            //currency.HighScore=data.HighScore;
            currency.TotalCoins = data.totalCoins;
            currency.Coins = data.CoinsCollected;
            currency.Score = data.RecentScore;
            currency.Debt = data.Debt;
            currency.Balance = data.totalCoins - data.Debt;
            if (currency.multiplier < 1)
            {
                currency.multiplier = 1;
            }
            SaveSystem.SaveCurrency(currency);
            Debug.Log(currency.HighScore);
        }
    }


}
