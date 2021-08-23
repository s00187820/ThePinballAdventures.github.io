using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public GameObject ResultsScrn,Goal, NextLevelBtn, RetryBtn;
    public GMController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.GetComponent<GMController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GMController.LevelNum==1)
        {
            if (controller.ScoreNum == 10)
            {
                Goal.SetActive(true);
            }
        }
        if (GMController.LevelNum == 2 && controller.ScoreNum == 1000)
        {
            Goal.SetActive(true);
        }
        if (GMController.LevelNum == 3 && controller.ScoreNum == 1000)
        {
            Goal.SetActive(true);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        ResultsScrn.SetActive(true);
        NextLevelBtn.SetActive(true);
        RetryBtn.SetActive(false);
        controller.Title.text = "Level Completed";
    }
}
