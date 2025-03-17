using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public AudioSource ButtonClickSFX;
    public AudioSource LoadingLevelSFX;
    public GameObject Changelog;
    private void Awake()
    {

        ButtonClickSFX.playOnAwake = false;
        if (LoadingLevelSFX != null)
        {
            LoadingLevelSFX.playOnAwake = false;
        }
        
    }
    void Start(){
        if(((PlayerPrefs.GetInt("Updated")!=1) || (PlayerPrefs.GetInt("NewHS")!=1 )) && (Changelog != null)){
            Changelog.SetActive(true);
            

        }   
        Debug.Log(((PlayerPrefs.GetInt("Updated")) + " , " + (PlayerPrefs.GetInt("NewHS"))) + " , " + (Changelog != null));
    }
    string level = ("SettingsMenu");
   // public void loadSettings(string SettingsMenu);
   public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
        ButtonClickSFX.Pause();
        LoadingLevelSFX.UnPause();
        LoadingLevelSFX.Play(0);
    }

    public void GotoStats()
    {
        SceneManager.LoadScene("Stats",LoadSceneMode.Single);
        ButtonClickSFX.Pause();
        LoadingLevelSFX.UnPause();
        LoadingLevelSFX.Play(0);
    }public void GotoLeaderboardMenu()
    {
        SceneManager.LoadScene("LeaderboardMenu",LoadSceneMode.Single);
        ButtonClickSFX.Pause();
        LoadingLevelSFX.UnPause();
        LoadingLevelSFX.Play(0);
    }
    public void Settings()
    {
        SceneManager.LoadScene("SettingsMenu",LoadSceneMode.Single);
        ButtonClickSFX.UnPause();
        ButtonClickSFX.Play(0);
    }

    public void ReturnToMainMenu()
    {    
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        ButtonClickSFX.UnPause();
        ButtonClickSFX.Play(0);
    }

    public void MuteAudio()
    {
        if (AudioListener.pause == false)
        {
            AudioListener.pause = true;
        }
        else 
        {
            AudioListener.pause = false;
        }
    }
    public void GoToStore()
    {
        SceneManager.LoadScene("Store");
        LoadingLevelSFX.Pause();
        ButtonClickSFX.UnPause();
        ButtonClickSFX.Play(0);
    }
    public void GoToCredits(){
        SceneManager.LoadScene("CreditsUI");
        LoadingLevelSFX.Pause();
        ButtonClickSFX.UnPause();
        ButtonClickSFX.Play(0);
    }
    public void ChangelogAccept(){
        Changelog.SetActive(false);
    }
}
//