using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillBall : MonoBehaviour
{
    [SerializeField]
    Transform Spawn;
    public GMController controller;
    public GameObject Ball,GameMaster;
    public Text Lifetxt;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameMaster.GetComponent<GMController>();
    }

    // Update is called once per frame
    void Update()
    {
        Lifetxt.text = controller.Life.ToString();
        //if(Input.GetKeyDown(KeyCode.R))
        //{
        //    Ball.transform.position = Spawn.position;
        //}
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("Ball"))
        {
            collision.transform.position = Spawn.position;
            controller.Life -= 1;
            if(controller.Life==0)
            {
                controller.Life = 0;
                controller.ResultScrn.SetActive(true);
                controller.Title.text = "Game Over";
                controller.ScoreR.text = controller.ScoreNum.ToString();
                controller.HighScore.text = controller.HighScoreNum.ToString();
                controller.UpdateHighscore();
            }
        }
    }
}
