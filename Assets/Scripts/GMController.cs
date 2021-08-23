using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GMController : MonoBehaviour
{
    public static int LevelNum;
    public static int GetLevelVariable()
    {
        return LevelNum;
    }
    public int ScoreNum = 0, HighScoreNum, Life=4;
    public GameObject W1,W2,W3,W3Blocker,Flippers,Ball,ResultScrn;
    public Text TimerText, Title,ScoreR,HighScore;
    float current=0f, starting=120f;
    private void Awake()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            HighScoreNum = PlayerPrefs.GetInt("HighScore");
            HighScore.text = HighScoreNum.ToString();
        }
    }
    public void Start()
    {
        current=starting;
       
    }
    public void Update()
    {
        current -= 1 * Time.deltaTime;
        TimerText.text = current.ToString("0");
        if(current<=0)
        {
            Ball.SetActive(false);
            current = 0;
            Time.timeScale = 1;
            ResultScrn.SetActive(true);
            Title.text = "Game Over";
            ScoreR.text = ScoreNum.ToString();
            HighScore.text = HighScoreNum.ToString();
            UpdateHighscore();
        }
        //if(Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //    LevelNum += 1;
        //    if(LevelNum==4)
        //    {
        //        LevelNum = 1;
        //    }
        //}
        switch(LevelNum)
        {
            case 1:
                W1.SetActive(true);
                W2.SetActive(false);
                W3.SetActive(false);
                Flippers.SetActive(true);
                //Ball.transform.position=new Vector3(-40, 12, -5);
                break;
            case 2:
                W1.SetActive(false);
                W2.SetActive(true);
                W3.SetActive(false);
                Flippers.SetActive(true);
                //Ball.transform.position = new Vector3(-39, 12, -5);
                break;
            case 3:
                W1.SetActive(false);
                W2.SetActive(false);
                W3.SetActive(true);
                W3Blocker.SetActive(false);
                Flippers.SetActive(false);
                //Ball.transform.position = new Vector3(-42, 12, -5);
                break;
        }
    }
    public void UpdateHighscore()
    {
        if (ScoreNum > HighScoreNum)
        {
            HighScoreNum = ScoreNum;
            PlayerPrefs.SetInt("HighScore", HighScoreNum);
        }
    }
    public void RetryGame()
    {
        SceneManager.LoadSceneAsync("Gameplay");
    }
    public void Back2Menu()
    {
        SceneManager.LoadSceneAsync("MainMenu"); 
    }
    public void NextLevel()
    {
        LevelNum = LevelNum + 1;
        if(LevelNum==4)
        {
            LevelNum = 1;
        }
        SceneManager.LoadScene("Gameplay");
    }
    public void NextLevel2()
    {
        LevelNum = LevelNum + 2;
        if (LevelNum == 4)
        {
            LevelNum = 1;
        }
        starting = 600f;
        ScoreNum = 0;
        Life = 4;
    }
    public void NextLevel3()
    {
        LevelNum = LevelNum + 3;
        if (LevelNum == 4)
        {
            LevelNum = 1;
        }
        starting = 600f;
        ScoreNum = 0;
        Life = 4;
    }
}
