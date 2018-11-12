using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameControler : MonoBehaviour {
    public CameraMovement cam;
    public GameObject CanvasMenu,Ballon,Hander,skins,Setting,levelText,LevelPref,ScoreMenu,Score,maps,SettingMenu,Gameover;
    // Use this for initialization
    void Start () {
        cam.GetComponent<CameraMovement>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        SG_AdManager.HideAllBanner();
	}

    public void LoadScene() {

         SceneManager.LoadScene("Gameplay");
    }

    public void PlayeGame() {
        Hander.SetActive(true);
        Ballon.SetActive(true);
        cam.GetComponent<CameraMovement>().enabled = true;
        CanvasMenu.SetActive(false);
        maps.SetActive(false);
        Time.timeScale = 1;
        levelText.SetActive(true);
        LevelPref.SetActive(false);
        Score.SetActive(true);
        ScoreMenu.SetActive(false);
    }
    public void Skins()
    {
        Hander.SetActive(false);
        Ballon.SetActive(false);
        cam.GetComponent<CameraMovement>().enabled = false;
        CanvasMenu.SetActive(false);
        skins.SetActive(true);
      
    }
    public void Back()
    {
        // SceneManager.LoadScene("Gameplay");
      //  maps.SetActive(false);
        CanvasMenu.SetActive(true);
        SettingMenu.SetActive(false);
        Ballon.SetActive(true);
        Gameover.SetActive(false);
    }
    public void Settings()
    {
        Hander.SetActive(false);
        Ballon.SetActive(false);
        cam.GetComponent<CameraMovement>().enabled = false;
        CanvasMenu.SetActive(false);
        skins.SetActive(false);
        Setting.SetActive(true);
    
    }
    public void ShowVideo() {

        SG_AdManager.RequestRewardedVideo();
        SG_AdManager.ShowRewardedVideo();
    // SG_AdManager.ads.RequestIntertitial();
      // SG_AdManager.ads.ShowIntertitial();

    }
   

}
