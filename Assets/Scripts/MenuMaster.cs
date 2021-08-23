using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMaster : MonoBehaviour
{
    public GMController controller;
    public GameObject menu;
    public void Start()
    {
        controller = menu.GetComponent<GMController>();
    }
    public void Gameplay1()
    {
        GMController.LevelNum = 1;
        SceneManager.LoadScene(1);
    }
    public void Gameplay2()
    {
        GMController.LevelNum = 2;
        SceneManager.LoadScene(1);
    }
    public void Gameplay3()
    {
        GMController.LevelNum = 3;
        SceneManager.LoadScene(1);
    }
}
