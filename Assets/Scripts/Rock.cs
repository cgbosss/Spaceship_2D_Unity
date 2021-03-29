using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public int rockLife = 5;
    public float rockSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //This function is to reduce the Rock life and delete it
    public void reduceRockLife()
	{
        if(rockLife == 0)
		{
            Destroy(gameObject);
		}
	}

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log("Rock triggered with " + hitInfo.name);
        Destroy(hitInfo.gameObject, 1f);
    }
}
