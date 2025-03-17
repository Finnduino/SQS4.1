using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawnPoint : MonoBehaviour
{
    public GameObject Coin;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Coin, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
