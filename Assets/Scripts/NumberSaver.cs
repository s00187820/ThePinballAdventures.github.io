using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NumberSaver : MonoBehaviour
{
    private void Awake()
    {
        int LevelData = GMController.GetLevelVariable();
    }
}
