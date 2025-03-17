using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayCoins : MonoBehaviour
{
    GameObject CoinsUI; 
    public GameObject MultiplierUI;
    float Coins;
    public Currency Currency;
    // Start is called before the first frame update
    void Start()
    {
        CoinsUI = GameObject.Find("TottaltCoins");
    }

    // Update is called once per frame
    void Update()
    {
        
      PlayerData data = SaveSystem.LoadCurrency();
      /*if(data.Balance == 0){
          Currency.Purchase(0);
      }*/
        Coins = data.Balance;

        CoinsUI.GetComponent<Text>().text = Coins.ToString();
        MultiplierUI.GetComponent<Text>().text = data.multiplier.ToString();

    }
}
