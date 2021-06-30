using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchSwipe : MonoBehaviour
{
    private Vector3 fp; // first position
    private Vector3 lp; // last position
    private int Moves=4; //Lives for the amount of times you can do this. will adjust later
    private float Drag; // length between the two positions
    // Start is called before the first frame update
    void Start()
    {
        Drag = Screen.height * 15 / 100;// Drag is always 15% of the overall screen both horizontal and vertical
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount==1)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                fp = touch.position;
                lp = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                lp = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                if (Moves == 0)
                {
                    Debug.Log("Out of moves yeah dummy");
                }
                else
                {
                    lp = touch.position;
                    if (Mathf.Abs(lp.x - fp.x) > Drag || Mathf.Abs(lp.y - fp.y) > Drag)
                    {
                        if (Mathf.Abs(lp.x - fp.x) > Mathf.Abs(lp.y - fp.y))
                        {
                            if ((lp.x > fp.x))
                            {
                                ////launch ball along RIGHT X axis
                                Debug.Log("Right");
                                Moves --;
                            }
                            else
                            {
                                //Launch ball along LEFT X axis
                                Debug.Log("Left");
                                Moves--;
                            }
                        }
                        else
                        {
                            if (lp.y > fp.y)
                            {
                                //launch ball along UP Y axis
                                Debug.Log("Up");
                                Moves--;
                            }
                            else
                            {
                                //launch ball all DOWN Y axis
                                Debug.Log("Down");
                                Moves--;
                            }
                        }
                    }
                }
            }
            else
            {
                ////treats itself as a TAP because drag is less that 20% of screen
            }
        }
        
    }
}
