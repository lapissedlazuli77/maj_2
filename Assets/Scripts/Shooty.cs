using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooty : MonoBehaviour
{
    public bool active;
    public Projectile projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Fire()
    {
        Vector3 rotation = transform.rotation.eulerAngles;
        Quaternion quatrot = Quaternion.Euler(rotation.x, rotation.y, rotation.z);
        Projectile proj = (Projectile)Instantiate(projectile, transform.position, quatrot);
        proj.GetComponent<Rigidbody2D>().AddForce(transform.up * 0.1f);
    }
}
