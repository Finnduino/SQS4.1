using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData{

    public float HighScore;
    public int totalCoins;
    public int CoinsCollected;
    public float RecentScore;
    public int Debt;
    public int Balance;
    public float multiplier;
    public PlayerData (Currency currency)
    {
        multiplier = currency.multiplier;
        HighScore = currency.HighScore;
        totalCoins = totalCoins + currency.TotalCoins;
        CoinsCollected = currency.Coins;
        RecentScore = currency.Score;
        Debt = Debt + currency.Debt;
        Balance = Balance + currency.Balance;
    }

}

