using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TenXBumperController : MonoBehaviour
{
    public GameObject GameMaster;
    public GMController controller;
    public Text ScoreText;
    public GameObject bumper;
    public Collider2D collider;
    int Ten = 10;
    public void Start()
    {
        controller = GameMaster.GetComponent<GMController>();
        collider = GetComponent<Collider2D>();
    }
    private void Update()
    {
        ScoreText.GetComponent<Text>().text = controller.ScoreNum.ToString();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            controller.ScoreNum+=Ten;
        }
    }
}
