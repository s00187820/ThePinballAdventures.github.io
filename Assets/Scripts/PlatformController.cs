using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public List<Transform> waypoint;
    public float speed;
    public int target;
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypoint[target].position, speed * Time.deltaTime);
    }
    private void FixedUpdate()
    {
        if(target<=0)
        {
            target = 0;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (transform.position == waypoint[target].position)
            {
                if (target == waypoint.Count - 1)
                {
                    target = 0;
                }
                else
                {
                    target += 1;
                }

            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (transform.position == waypoint[target].position)
            {
                if (target == waypoint.Count + 1)
                {
                    target = 0;
                }
                else
                {
                    target -= 1;
                }
            }
        }
    }
}
