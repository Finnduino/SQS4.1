using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{

    public GameObject[] Coinpatterns;
    private float TimeBtwSpawn;
    public float StartTimeBtwSpawn;
    public float DecreaseStep;
    public float minTimeofSpawn;
    public float forwardForce = 100f;

    void Update()
    {
      
        if (TimeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, Coinpatterns.Length);
            Instantiate(Coinpatterns[rand], transform.position, Quaternion.identity);
            TimeBtwSpawn = StartTimeBtwSpawn;
            if (TimeBtwSpawn > minTimeofSpawn)
            {
                StartTimeBtwSpawn -= DecreaseStep;
             

            }
        }

        else
        {
            TimeBtwSpawn -= Time.deltaTime;
        }


    }

}
