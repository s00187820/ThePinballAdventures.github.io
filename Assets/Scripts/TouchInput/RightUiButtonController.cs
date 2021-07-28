using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RightUiButtonController : MonoBehaviour, IUpdateSelectedHandler, IPointerDownHandler, IPointerUpHandler
{
    int Jointnum;
    public bool ispressed;
    public FlipperControllerRight right;
    public GameObject jointselect;
    public GameObject[] jointarray;
    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
    }

    public void OnUpdateSelected(BaseEventData eventData)
    {
        if (ispressed)
        {
           right.IsKeyPressedRight = true;
        }
        else
        {
            right.IsKeyPressedRight = false;
        }
    }

}
