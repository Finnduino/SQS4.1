using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicKeeper : MonoBehaviour
{
    public AudioSource BGMusic;
    static MusicKeeper instance = null;
    private void Awake()
    {
         if(instance != null)
        {
            
            Destroy(gameObject);
        }
         else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
            BGMusic.UnPause();
        }
 
        

    }
    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "GameScene")
        {
           // Debug.Log(SceneManager.GetActiveScene().name);
            BGMusic.Pause();

        }
        else{
            BGMusic.UnPause();
        }
   //     Debug.Log(Input.G);
        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("YOMAMMAGAY");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }


}


