using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Pauser : MonoBehaviour
{


public GameObject PauseMenuUI;

 public void Pause(){
     PauseMenuUI.SetActive(true);
     Time.timeScale = 0f;

 }

 public void UnPause(){
    PauseMenuUI.SetActive(false);
    Time.timeScale = 1f;
 } 

}
