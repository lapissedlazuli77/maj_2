using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float maxMoveSpeed = 12;
    public float smoothTime = 0.1f;
    Vector2 currentVelocity;
    bool ismoving = false;

    public int health = 4;
    public int ammo = 4;

    Vector2 newpos = Vector2.zero;

    public WallDetector upcollider;
    public WallDetector leftcollider;
    public WallDetector rightcollider;
    public WallDetector downcollider;

    public string whichshooter;
    public Shooty upshooter;
    public Shooty leftshooter;
    public Shooty rightshooter;
    public Shooty downshooter;

    // Start is called before the first frame update
    void Start()
    {
        whichshooter = "up";
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
            whichshooter = "up";
            newpos = currentpos + new Vector2(0, 1);
        }
        if (Input.GetKeyDown("s") && downcollider.collided == false)
        {
            ismoving = true;
            whichshooter = "down";
            newpos = currentpos + new Vector2(0, -1);
        }
        if (Input.GetKeyDown("a") && leftcollider.collided == false)
        {
            ismoving = true;
            whichshooter = "left";
            newpos = currentpos + new Vector2(-1, 0);
        }
        if (Input.GetKeyDown("d") && rightcollider.collided == false)
        {
            ismoving = true;
            whichshooter = "right";
            newpos = currentpos + new Vector2(1, 0);
        }

        if (Input.GetKeyDown("space") && ammo >= 1)
        {
            if (whichshooter == "up") { upshooter.Fire(); }
            else if (whichshooter == "left") { leftshooter.Fire(); }
            else if (whichshooter == "right") { rightshooter.Fire(); }
            else if (whichshooter == "down") { downshooter.Fire(); }
            ammo--;
        }
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
        //if (collision.gameObject.tag == "Finish")
        //{

        //}
    //}
}
