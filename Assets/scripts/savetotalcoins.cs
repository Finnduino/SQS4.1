using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class savetotalcoins : MonoBehaviour
{
    Currency currency;
    int totalCoins;
    int Coins;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // FindObjectOfType<Currency>().Coins = Coins;
        PlayerData data = SaveSystem.LoadCurrency();
        data.totalCoins = totalCoins;
        totalCoins =+ Coins;
    //    SaveSystem.SaveCurrency(currency);
    }
}
