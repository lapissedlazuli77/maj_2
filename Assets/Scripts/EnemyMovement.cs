using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    float speed;
    int health;

    public WallDetector collider1;
    public WallDetector collider2;

    public EnemyDetector collide1;
    public EnemyDetector collide2;

    Rigidbody2D rBody;
    public string axis;
    float plusorminus;

    // Start is called before the first frame update
    void Start()
    {
        health = Random.Range(2, 5);
        speed = Random.Range(0.1f, 0.7f);
        
        rBody = GetComponent<Rigidbody2D>();
        int randompick = Random.Range(1, 3);
        if (randompick == 1) { plusorminus = 1; }
        else if (randompick == 2) { plusorminus = -1; }

        if (axis == "x") {
            rBody.velocity = plusorminus * transform.right * speed;
        } else if (axis == "y") {
            rBody.velocity = plusorminus * transform.up * speed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (collider1.collided == true || collider2.collided == true)
        {
            rBody.velocity *= -1;
        }
        if (collide1.collided == true || collide2.collided == true)
        {
            rBody.velocity *= -1;
        }
        if (health <= 0) { Destroy(gameObject); }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            Destroy(collision.gameObject);
            health--;
        }
    }
}
