using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetHighScore : MonoBehaviour
{
    
    Currency Currency;
   public GameObject HighScoreUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HighScoreUI = GameObject.Find("HighScore");
    }

public void UpdateHighScore(string HighScore)
    {
      //  Debug.Log("NEGROES ARE GAY");
        HighScoreUI.GetComponent<Text>().text = HighScore;
    }


}
