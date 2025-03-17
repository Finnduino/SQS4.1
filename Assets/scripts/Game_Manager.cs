using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    public int DeathCounter = 1;
    int DeathNumber = 0;
    public AdsDeploy adsDeploy;
   public Currency currency;
    
   public AudioSource DeathSound;

    bool GameHasEnded = false;

    public float RestartTime = 0;

    public GameObject completelevelUI;

    public int TotalCoins;

   public bool playerstate = false;
   public int AdCounter;
    bool Million = false;
    bool HundredK = false;
    bool TenK = false;
    bool OneK = false;
   string AdCount;
/*
    public void CompleteLevel()
    {
        Debug.Log("Level won!");
        completelevelUI.SetActive(true);
    }*/
//
public float test;

    public void ReportAchivements(int Score){
        if(Score >= 1000000 && !Million){
         Social.ReportProgress(GPGSIds.achievement_the_legendary_1_million, 100.0f, null);
            Million = true;
        }
        else if(Score >= 100000 && !HundredK){
        Social.ReportProgress(GPGSIds.achievement_100_000_points, 100.0f, null);
            HundredK = true;
        }
        else if(Score >= 10000 && !TenK){
        Social.ReportProgress(GPGSIds.achievement_10_000_points, 100.0f, null);
            TenK = true; 
        }
        else if(Score >= 1000 && !OneK){
        Social.ReportProgress(GPGSIds.achievement_1000_points, 100.0f, null);
            OneK = true;
            }
        
    }
    public void Endgame()
    {
        if(PlayerPrefs.GetInt(AdCount) == 0){
            PlayerPrefs.SetInt(AdCount,1);
        }
        //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
        Time.timeScale = 1f;
        if (GameHasEnded == false)
        {
            if (playerstate == false)
            {
                playerstate = true;
            }
            currency.SaveTotalCoinData();
            DeathSound.Play(0);
            GameHasEnded = true;
            PlayerData data = SaveSystem.LoadCurrency();
            if(currency.HighScore != currency.Score){
            PlayerPrefs.SetInt(AdCount, PlayerPrefs.GetInt(AdCount) + 1);
            Debug.Log("Ads" + PlayerPrefs.GetInt(AdCount)); 
            if(PlayerPrefs.GetInt(AdCount) >= 4){
            PlayerPrefs.SetInt(AdCount,1);
            adsDeploy.DeployAd();
            }
            }
            Social.ReportScore((long)data.HighScore, GPGSIds.leaderboard_highscore_v2, (bool success)=>{
                if(success){
                    Debug.Log("Highscore 2 synced with Google!");
                }
                else{
                    Debug.LogError("Unable to sync highscore 2 with Google.");
                }
            });
            Social.ReportScore((long)data.CoinsCollected, GPGSIds.leaderboard_most_coins_collected_in_one_run, (bool success)=>{
                if(success){
                    Debug.Log("CoinHighScore synced with Google!");
                }
                else{
                    Debug.LogError("Unable to sync CoinHighScore with Google.");
                }
            });
            Debug.Log("GAME OVER!");
            SceneManager.LoadScene("ReStart");



        }


    }
    

}