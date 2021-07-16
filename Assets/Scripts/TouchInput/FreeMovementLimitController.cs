using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FreeMovementLimitController : MonoBehaviour
{
    public Text FreeMoveText;
    private TouchSwipe M;
   [SerializeField] public float MovesNum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovesNum = TouchSwipe.Moves;
        FreeMoveText.text = MovesNum.ToString();
    }
}
