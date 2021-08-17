using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BumperPointer : MonoBehaviour
{
    public int score=0;
    public Text ScoreText;
    public void Start()
    {
        //ScoreText = gameObject.GetComponent<Text>();
    }
    private void Update()
    {
        ScoreText.GetComponent<Text>().text = score.ToString();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Ball")
        {
            score++;
        }
    }
}
