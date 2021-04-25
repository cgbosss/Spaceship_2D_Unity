using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounderCollide : MonoBehaviour
{

/// <summary>
/// This scripts check if the Objects are colliding with the Collision Trigger and removes them.
/// </summary>

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Remove the Objects that come into the trigger
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log("Rock Bounder triggered with " + hitInfo.name);
        Destroy(hitInfo.gameObject, 0.05f);
    }
}
