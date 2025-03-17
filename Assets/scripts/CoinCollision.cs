using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinCollision : MonoBehaviour
{
    Currency Script;
    public Playermovement movement;
    public int addAmount;

    private void Start()
    {
        Script = GameObject.FindWithTag("GameController").GetComponent<Currency>();
    }
    private void Update()
    {
      //  Debug.Log(Script);
    }
    void OnTriggerEnter(Collider collider)
    {
        
        Script.Coins += addAmount;
        Collider.Destroy(collider);
        //  movement.enabled = false;
        //     FindObjectOfType<Currency>().Endgame();

    }
    



}
