using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossBumperController : MonoBehaviour
{
    public GameObject GameMaster;
    public GMController controller;
    public Text ScoreText;
    public GameObject bumper;
    public Collider2D collider;
    public void Start()
    {
        controller = GameMaster.GetComponent<GMController>();
        collider = GetComponent<Collider2D>();
    }
    private void Update()
    {
        ScoreText.GetComponent<Text>().text = controller.Score.ToString();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            controller.Score+=100;
        }
    }
}
