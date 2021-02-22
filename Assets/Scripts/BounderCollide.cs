using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounderCollide : MonoBehaviour
{
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
        Debug.Log("Border triggered with " + hitInfo.name);
        Destroy(hitInfo.gameObject, 1f);

    }
}
