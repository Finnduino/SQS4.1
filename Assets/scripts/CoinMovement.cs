using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMovement : MonoBehaviour
{
  //  public float forwardForce;
    public Transform wall;
    public Rigidbody rb;
    // Start is called before the first frame update
    public float ForwardForce;
   // float ForwardForce = 100f;
   // float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;

    }



    // Update is called once per frame
   
    public void UpdateCoinSpeed(float forwardForce)
    {
        ForwardForce += forwardForce;
        rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
       //Debug.Log(ForwardForce);
    }

    public void FixedUpdate()
    {
        //ForwardForce = 400;
        rb.AddForce(0, 0, -ForwardForce * Time.deltaTime);
        Debug.Log(ForwardForce*Time.deltaTime);
    }

}