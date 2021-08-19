using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeftUiButtonController : MonoBehaviour,  IPointerDownHandler, IPointerUpHandler
{
    public bool ispressed;
    public FlipperControllerLeft left;

    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
    }

    public void Update()
    {
        if (ispressed)
        {
            left.IsKeyPressedLeft = true;
        }
        else
        {
            left.IsKeyPressedLeft = false;
        }
    }
}
