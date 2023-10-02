using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathfog : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.y += speed;
        transform.position = currentPosition;
    }
}
