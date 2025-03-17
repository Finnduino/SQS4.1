using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFPS : MonoBehaviour
{

public void ThirtyFPS(){
    UpdateFPS();
    PlayerPrefs.SetInt("TargetFPS", 30);
}   public void SixtyFPS(){
    PlayerPrefs.SetInt("TargetFPS", 60);
    UpdateFPS();
}   public void OneTwenyFPS(){
    PlayerPrefs.SetInt("TargetFPS", 120);
    UpdateFPS();
}   

public void UpdateFPS(){
    Application.targetFrameRate=PlayerPrefs.GetInt("TargetFPS");
}

}
