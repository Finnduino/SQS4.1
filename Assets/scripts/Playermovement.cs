using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    Vector2 Finga0Location;
    float FingerLoc;
    public Transform player;
    public Rigidbody rb;
    public Vector3 PlayerPosition;
    // Start is called before the first frame update
    public float forwardForce;
    public float sidewaysForce;
    public float JoystickState;
    public float powerto;
    Touch touch;
    float RelativetTouchPos;
    float JoystickPOS;

    void Start()

    {
        PlayerPosition = player.position;
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
      //  rb.AddForce(0,1000,0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            FingerLoc = touch.position.x;
            RelativetTouchPos = FingerLoc / (Screen.width / 2) - 1;
          //  JoystickState = variableJoystick.Horizontal;
            // powerto = Mathf.Pow(JoystickState, JoystickState);
            JoystickPOS =  sidewaysForce * RelativetTouchPos * Time.deltaTime;
            player.Translate(Vector3.forward*JoystickPOS);
        }
            //  Debug.Log(powerto);

        




        // rb.AddForce(0,0,forwardForce  * Time.deltaTime);


        /*
        if (Input.touchCount > 0)
        {
            
            Touch touch = Input.GetTouch(0);
            Finga0Location = touch.position;
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
           // touchPosition.z = 69f;
            //player.position = touch.position;
            //  Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch)
           // Debug.Log(Finga0Location.x);

            if (Finga0Location.x > 150)
            {
                //    rb.AddForce(sidewaysForce * FrameTime, 0, 0, ForceMode.VelocityChange);
                // rb.AddForce(sidewaysForce, 0, 0);
                player.Translate(Vector3.forward * Time.deltaTime * sidewaysForce);
            }

            if (Finga0Location.x < 150)
            {
                player.Translate(-Vector3.forward * Time.deltaTime * sidewaysForce);
            }

            Debug.Log(Finga0Location);
        }
        */
        if (Input.GetKey("d"))
        {
          //  rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
          //  PlayerPosition.x = +1;
           // player.position = PlayerPosition;
          //  player.position = -player.right;
            player.Translate(Vector3.forward * Time.deltaTime * sidewaysForce);
        }

        if (Input.GetKey("a"))
        {

            // rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            //PlayerPosition.x = -1;
            //player.position = PlayerPosition = +1;
            player.Translate(-Vector3.forward * Time.deltaTime * sidewaysForce);
        }
        

        if (rb.position.y < -1f)
        {
            FindObjectOfType<Game_Manager>().Endgame();
        }

        if(rb.position.x > 25)
        {
            player.position = new Vector3(-23, 0, -69);
        }

        if (rb.position.x < -25)
        {
            player.position = new Vector3(23, 0, -69);
        }
     //   Debug.Log(rb.position);

        




    }
}
