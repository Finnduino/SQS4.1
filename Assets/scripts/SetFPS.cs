using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFPS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int fps = PlayerPrefs.GetInt("TargetFPS");
        if(fps==0){
        Application.targetFrameRate = 60;
        PlayerPrefs.SetInt("TargetFPS", 60);
        }
        else{
            Application.targetFrameRate=fps;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
