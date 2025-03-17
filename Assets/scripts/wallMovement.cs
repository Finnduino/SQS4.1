using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallMovement : MonoBehaviour
{
    public float forwardForce;
    public Transform wall;
    public Rigidbody rb;
    bool Updatewallspeed;
    // Start is called before the first frame update
    public float ForwardForce;
   // float ForwardForce = 100f;
   // float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        Updatewallspeed = true;
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;

    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            Debug.Log("The Player Has Died");
            Updatewallspeed = false;

          //  ForwardForce = -500;
        }
    }

    // Update is called once per frame

    public void UpdateWallSpeed(float forwardForce)
    {
     //   if (Updatewallspeed == true)
    //    {
            ForwardForce -= ForwardForce;
            ForwardForce += forwardForce;
        //}
        //rb.AddForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.Force);
     //   Debug.Log(forwardForce);
    }

    public void FixedUpdate()
    {
      //  if (Updatewallspeed == true)
       // {
            rb.AddForce(0, 0, -ForwardForce * Time.deltaTime, ForceMode.Force);
            //Debug.Log(ForwardForce);
       // }
       


    }

   
}