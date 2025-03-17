using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDelete : MonoBehaviour
{

    // Start is called before the first frame update
    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
        }
        else if(collision.tag == "Endwall"){
            Destroy(gameObject);
        }
    }

}
