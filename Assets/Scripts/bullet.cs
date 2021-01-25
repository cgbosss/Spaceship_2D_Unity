using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public Rigidbody2D rbBullet;
    public int bulletHitDamage = 1;

    // Start is called before the first frame update
    void Start()
    {
        rbBullet.velocity = transform.right * bulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log("Laser collided with " + hitInfo.name);
        Destroy(gameObject, 3f);

    }

}
