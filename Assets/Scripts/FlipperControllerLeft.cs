using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperControllerLeft : MonoBehaviour
{
    public bool IsKeyPressedLeft = false;
    public bool IstouchedLeft = false;
    public float speed = 1700f;
    private HingeJoint2D hinge;
    private JointMotor2D joint;
    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
        joint = hinge.motor;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            IsKeyPressedLeft = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            IsKeyPressedLeft = false;
        }
    }
    void FixedUpdate()
    {
        if (IsKeyPressedLeft == true && IstouchedLeft == false || IsKeyPressedLeft && IstouchedLeft == true)
        {
            joint.motorSpeed = speed;
            hinge.motor = joint;
        }
        else
        {
            joint.motorSpeed = -speed;
            hinge.motor = joint;
        }
    }
}
