using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public CoinMovement2 CoinMovement2;
    public CoinMovement CoinMovement;
    public wallMovement wallMovement;
    public float AddedForce;
    public float forwardForce;
    public float MaxForce;
    //  public Transform wall;
   // public Rigidbody rb;
  //  public GameObject Wall;
    public GameObject[] wallpatterns;
    private float TimeBtwSpawn;
    public float StartTimeBtwSpawn;
    public float DecreaseStep;
    public float minTimeofSpawn;

    private void Start()
    {

    }
    private void Update()
    {
        //    rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
     
        if (TimeBtwSpawn <= 0)
        {
            
            int rand = Random.Range(0, wallpatterns.Length);
            Instantiate(wallpatterns[rand], transform.position, Quaternion.identity);
            TimeBtwSpawn = StartTimeBtwSpawn;
            if (TimeBtwSpawn > minTimeofSpawn)
            {
                if (forwardForce < MaxForce)
                {
                    forwardForce += AddedForce;
                }
                StartTimeBtwSpawn -= DecreaseStep;

                wallMovement.UpdateWallSpeed(forwardForce);
                CoinMovement.UpdateCoinSpeed(forwardForce);
                CoinMovement2.GetSpeed(forwardForce);
            }
            
        }

        else
        {
            TimeBtwSpawn -= Time.deltaTime;
        }


    }

}
