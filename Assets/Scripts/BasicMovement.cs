using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float maxMoveSpeed = 12;
    public float smoothTime = 0.1f;
    Vector2 currentVelocity;
    bool ismoving = false;

    Vector2 newpos = Vector2.zero;

    public WallDetector upcollider;
    public WallDetector leftcollider;
    public WallDetector rightcollider;
    public WallDetector downcollider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (ismoving)
        {
            Vector2 pos = transform.position;
            if (pos == newpos)
            {
                ismoving = false; 
            }
            transform.position = Vector2.SmoothDamp(transform.position, newpos, ref currentVelocity, smoothTime, maxMoveSpeed);
        }

        Vector2 currentpos = transform.position;
        if (Input.GetKeyDown("w") && upcollider.collided == false)
        {
            ismoving = true;
            newpos = currentpos + new Vector2(0, 1);
        }
        if (Input.GetKeyDown("s") && downcollider.collided == false)
        {
            ismoving = true;
            newpos = currentpos + new Vector2(0, -1);
        }
        if (Input.GetKeyDown("a") && leftcollider.collided == false)
        {
            ismoving = true;
            newpos = currentpos + new Vector2(-1, 0);
        }
        if (Input.GetKeyDown("d") && rightcollider.collided == false)
        {
            ismoving = true;
            newpos = currentpos + new Vector2(1, 0);
        }
    }
}
