using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remove_explosionSprite : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 4.05f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
