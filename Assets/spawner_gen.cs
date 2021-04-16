using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner_gen : MonoBehaviour
{
    /// <summary>
    /// Generic Spawner Object
    /// </summary>
    /// 
    public GameObject SpawnObject;
    public Transform SpwnPointOne;
    public float spawnDelay;
    public float spawnTime;

    // Start is called before the first frame update
    void Start()
    {
        //Checker for GameObject is Null
        if (SpawnObject != null)
        {
            Debug.Log("Spawn Object is found " + SpawnObject.name);
            //Do Some Code hwere

        }
        else
        {
            SpawnObject = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
