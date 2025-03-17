using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{

    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Endwall")
        {
            Destroy(gameObject);
        }
    }

}
