using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;


class PlayGamesController : MonoBehaviour
{              
    public GameObject SignInui;
    // Start is called before the first frame update
  
  
      void Start()
    {
        PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
        PlayGamesPlatform.InitializeInstance(config);
        PlayGamesPlatform.Activate();
        Debug.Log("Yes, I can!");
        AuthUser();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowLeaderBoardv2(){
            PlayGamesPlatform.Instance.ShowLeaderboardUI(GPGSIds.leaderboard_highscore_v2);
            Debug.Log("Showing leaderboard!");
        }
        public void ShowCoinLeaderBoard(){
            PlayGamesPlatform.Instance.ShowLeaderboardUI(GPGSIds.leaderboard_most_coins_collected_in_one_run);
            Debug.Log("Showing coin leaderboard!");
        } 

    public void AuthUser(){

        //Social.Active.Authenticate((bool success) =>
        Social.localUser.Authenticate((success) => 
        {
            if (success == true){
            Debug.Log("Player has registered");
            SignInui.SetActive(false);
            }
            else{
                Debug.LogError("You Fucked up män");
            SignInui.SetActive(false);
            }
        });
    
    
      }
   
        
        
   }




