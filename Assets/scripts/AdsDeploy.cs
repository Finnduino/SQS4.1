using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class AdsDeploy : MonoBehaviour
{
    // Start is called before the first frame update
   public IEnumerator Start()
    {
        Advertisement.Initialize("3570101", true);
        while(!Advertisement.IsReady()){
            yield return null;
        }
    }

    public void DeployAd(){
        Advertisement.Show();
        Debug.Log("Showing Ads.");
    }



}
