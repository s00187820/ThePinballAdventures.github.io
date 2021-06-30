using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlungerController : MonoBehaviour
{
    public bool IsTouched = false;
    public bool IsKeyPressed = false;
    public bool IsActive = false;
    public float PressDuration = 0f;
    public float StartingDuration = 0f;
    public int PowerIND;
    public SpringJoint2D spring;
    public Rigidbody2D rb;
    public float frc = 0f;
    public float maxfrc = 100f;
    
    // Start is called before the first frame update
    void Start()
    {
        spring = GetComponent<SpringJoint2D>();
        spring.distance = 1f;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(IsActive)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                IsKeyPressed = true;
            }
            if(Input.GetKeyUp(KeyCode.Space))
            {
                IsKeyPressed = false;
            }
            if(IsKeyPressed==true && IsTouched==false|| IsKeyPressed==false && IsTouched==true)
            {
                if(StartingDuration==0f)
                {
                    StartingDuration = Time.time;
                }
            }
            if(IsKeyPressed==false && IsTouched==false && StartingDuration!=0f)
            {
                frc = PowerIND * maxfrc;
                PressDuration = 0f;
                StartingDuration = 0f;
                while (PowerIND>=0)
                {
                    PowerIND--;
                }
            }
        }

    }
     void FixedUpdate()
    {
        if(frc!=0)
        {
            spring.distance = 1f;
            rb.AddForce(Vector3.up * frc);
            frc = 0;
        }
        if(PressDuration!=0)
        {
            spring.distance = .8f;
            rb.AddForce(Vector3.down * 400);
        }
    }
}
