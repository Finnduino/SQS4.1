using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollision : MonoBehaviour
{
    public Game_Manager Game_Manager;
    public Playermovement movement;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "wall")
        {
            movement.enabled = false;
          //  FindObjectOfType<Game_Manager>().Endgame();
            Game_Manager.Endgame();
        }
    }
}
