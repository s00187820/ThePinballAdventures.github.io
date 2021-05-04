using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperController : MonoBehaviour
{
    public bool IsKeyPressed = false;
    public bool Istouched = false;
    public float speed = 1700f;
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
        if (IsKeyPressed == true && Istouched == false || IsKeyPressed && Istouched == true)
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

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            IsKeyPressed = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            IsKeyPressed = false;
        }
    }
}
