using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BoosterCostUpdater : MonoBehaviour
{
    Text text;
    public float price;
    // Start is called before the first frame update
    void Start()
    {
        text = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Each booster adds \n a 0,2x multiplier \n \n Cost: " + price.ToString("0") +" Coins";
    }
    public void UpdateShowPrice(float hinta){
        price = hinta;
    }
}
