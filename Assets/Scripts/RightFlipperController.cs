using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFlipperController : MonoBehaviour
{
    public bool IsKeyPressed = false;
    public bool Istouched = false;
    public float speed = 0f;
    private HingeJoint2D hinge;
    private JointMotor2D joint;
    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
        joint = hinge.motor;
    }

    private void FixedUpdate()
    {
        if (IsKeyPressed==true&&Istouched==false||IsKeyPressed&&Istouched==true)
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

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            IsKeyPressed = true;
        }
        if(Input.GetKeyUp(KeyCode.RightArrow))
        {
            IsKeyPressed = false;
        }
    }
}
