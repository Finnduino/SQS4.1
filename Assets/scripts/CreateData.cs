using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class CreateData : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        string path = Application.persistentDataPath + "/data.lmao";

        if(File.Exists(path)){
        } 
        else{
            PlayerPrefs.SetInt("DataExists", 0);
            Debug.Log("SET");
        
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
