using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{

    public GameObject laserSprite;
    public Transform firePoint;

    // Start is called before the first frame update
    void Start()
    {
       

        
    }

    // Update is called once per frame
    void Update()
    {
        FireLazer();

    }

    //Fire Laser
    void FireLazer()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(laserSprite, firePoint.position, firePoint.rotation);
        }
    }
}
