using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Balloon : MonoBehaviour {

    private Text ScoreText;
    public GameObject CanvasScore;
    public Text Score;
    public GameObject hander;
    public CameraMovement cam;

    public Text hightScore;
    public Text hightScoreMenu;
    public int number;




    private void Start() {
        ScoreText = GameManager.gm.GameplayUI.Find("ScorePlaceholder").Find("Score").GetComponent<Text>();
        hightScore.text = PlayerPrefs.GetInt("HightScore", 0).ToString();
        hightScoreMenu.text = PlayerPrefs.GetInt("HightScore", 0).ToString();
    }

    private void Update() {

        number = Mathf.Max(0, Mathf.FloorToInt(transform.position.y));

        ScoreText.text = number.ToString();
        Score.text = Mathf.Max(0, Mathf.FloorToInt(transform.position.y)).ToString();
        if (number > PlayerPrefs.GetInt("HightScore", 0)) {
            PlayerPrefs.SetInt("HightScore", number);
            hightScore.text = number.ToString();
            hightScoreMenu.text = number.ToString();
        }


    }
    /*  public void ResetScore() {
          PlayerPrefs.DeleteAll();
      }*/
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Obstacle") {
            // StartCoroutine(PrintfAfter(1.0f));
            Invoke("setCan",1f);
            print("GAME OVER!");
            //SceneManager.LoadScene ("Gameplay");
           
            Time.timeScale = 0.5f;
           
            hander.SetActive(false);
            //  Time.timeScale = 0;
            this.gameObject.SetActive(false);
            cam.GetComponent<CameraMovement>().enabled = false;
            if (PlayerPrefsManager.Instance.Vibrate)
            {
                Handheld.Vibrate();
            }



        }
        else if (other.tag == "LevelEnd") {
            other.tag = "Untagged"; //Can trigger only once (needs, bcz balloon has 2 colliders)
            GameManager.gm.lm.SpawnLevel();
        }
    }
    public void setCan() {
        CanvasScore.SetActive(true);
        Time.timeScale = 0f;
    }
   
    IEnumerator PrintfAfter(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Debug.Log("Done " + Time.time);
        CanvasScore.SetActive(true);
        Time.timeScale = 0f;
    }
}