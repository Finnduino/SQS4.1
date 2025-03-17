using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMovement2 : MonoBehaviour
{
    public Generator Generator;  
    public Rigidbody rb;
    public Transform Transform;
    public float SPEED;
    public float CoinSpeed;
    // Start is called before the first frame update
    void Start()
    {
      //  CoinSpeed = Generator.forwardForce;
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }
    public void GetSpeed(float forwardForce)
    {

        CoinSpeed = forwardForce;
        CoinSpeed = forwardForce;

    }
    // Update is called once per frame

    public void FixedUpdate()
    { 

        rb.AddForce(0, 0, -CoinSpeed * Time.deltaTime);

        //   Debug.Log(CoinSpeed);
    }

   
}
