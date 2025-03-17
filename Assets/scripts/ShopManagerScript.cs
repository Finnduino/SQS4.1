using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManagerScript : MonoBehaviour
{
    public Currency Currency;
    public float BoosterPriceMultiplier = 1.15f;
    PlayerData data;
    float BoosterPrice = 1000f;
    float OriginalBoosterPrice = 1000;
    public BoosterCostUpdater BoosterCostUpdater;
    void Start() {
    //BoosterCostUpdater = this.GetComponentInChildren<BoosterCostUpdater>();
    Currency.UpdateBalance();
    data = SaveSystem.LoadCurrency();
    if(BoosterPrice != OriginalBoosterPrice*Mathf.Pow(BoosterPriceMultiplier, BoosterMultiplier(data.multiplier))){
    BoosterCostUpdater.UpdateShowPrice(OriginalBoosterPrice*Mathf.Pow(BoosterPriceMultiplier, BoosterMultiplier(data.multiplier)));
    }    
    BoosterCostUpdater.UpdateShowPrice(OriginalBoosterPrice*Mathf.Pow(BoosterPriceMultiplier, BoosterMultiplier(data.multiplier)));
    }
    public void BuyBooster(){
    data = SaveSystem.LoadCurrency();
    if(data.Balance >= BoosterPrice && data.multiplier < 2f){
    BoosterPrice = BoosterPrice*Mathf.Pow(BoosterPriceMultiplier, BoosterMultiplier(data.multiplier));
    
    Currency.Purchase(Mathf.RoundToInt(BoosterPrice));
    Currency.purchaseTwoMultiplier();
    data = SaveSystem.LoadCurrency();
    BoosterCostUpdater.UpdateShowPrice(OriginalBoosterPrice*Mathf.Pow(BoosterPriceMultiplier, BoosterMultiplier(data.multiplier)));
    }
    }
    public static float BoosterMultiplier(float multiplier){
        float TrueMultiplier = (multiplier-1)*5;
        return TrueMultiplier;
    }    

}
