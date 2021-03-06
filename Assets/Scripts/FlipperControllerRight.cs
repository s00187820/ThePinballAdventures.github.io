using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FlipperControllerRight : MonoBehaviour
{
    public bool ispressed;
    public bool IsKeyPressedRight = false;
    public bool IstouchedRight = false;
    public float speed = 1700f;
    private HingeJoint2D hinge;
    private JointMotor2D joint;
    public Button Right;
    void Start()
    {
        

        hinge = GetComponent<HingeJoint2D>();
        joint = hinge.motor;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            IsKeyPressedRight = true;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            IsKeyPressedRight = false;
        }

    }
    
    
    void FixedUpdate()
    {
        if (IsKeyPressedRight == true && IstouchedRight == false || IsKeyPressedRight && IstouchedRight == true)
        {
            joint.motorSpeed = -speed;
            hinge.motor = joint;
        }
        else
        {
            joint.motorSpeed = speed;
            hinge.motor = joint;
        }
    }
    
}

