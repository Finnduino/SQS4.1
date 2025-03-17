using UnityEngine;
using System.Collections;

public class ConstantRotation : MonoBehaviour
{

    public float xSpeed = 1000f;
    public float ySpeed = 1000f;
    public float zSpeed = 1000f;

    // Update is called once per frame
    void Update()
    {
        // rotate x, y and z with different rotation speed 
        transform.Rotate(xSpeed * Time.deltaTime, ySpeed * Time.deltaTime, zSpeed * Time.deltaTime);
    }
}