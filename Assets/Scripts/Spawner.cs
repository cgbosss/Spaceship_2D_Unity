using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    /// <summary>
    /// This is to spawn the Stars and Asteroids on screen
    /// </summary>

    //Get the position of the Spawn points
    //Create an Instance of the Star Object//
    //Add Delay to delete
    //Make sure screen does not have too many Instances Spawns Max 10
    //Spawner will not end until the game quits or player loses all life

    public Transform SpwnPointOne;
    public Transform SpwnPointTwo;
    public GameObject StarObj;
    public GameObject StarObjSpecial;

    public Vector3 NewStarVect;
    public int MaxStarCount;

    private bool SpawnStar = false;
    public float spawnDelay;
    public float spawnTime;

    // Start is called before the first frame update
    void Start()
    {
        MaxStarCount = 0;
        InvokeRepeating("spawnStar", 3f, spawnDelay); //THis code runs the Spawner Ever 3 seconds
    }

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine(startSpawningStars());

        //Debug.Log("Tracking The Count Stars" + MaxStarCount);

        //Set the Max Number of Star
        /*if (MaxStarCount < 20)
		{
            StartCoroutine(startSpawningStars());

            MaxStarCount += 1;

            Debug.Log("Star Spawn Star: " + MaxStarCount);
		}
        else if (MaxStarCount == 20)
		{
            Debug.Log("Star Checking for Star Collisions and Remove it");
            MaxStarCount = 0;
            Debug.Log("Reset Max Star to " + MaxStarCount);
		}*/


    }

    IEnumerator startSpawningStars()
    {
        yield return new WaitForSeconds(spawnDelay);

    }

    void spawnStar()
	{
        MaxStarCount += 1;
        Instantiate(StarObj, SpwnPointOne.position, SpwnPointOne.rotation);
        Debug.Log("MaxStarCount: " + MaxStarCount);
	}



    //The star Count is updated once the object has been removed
    public void decreaseStarCount()
	{
        MaxStarCount =- 1;
        Debug.Log("Decrease Star Count" + MaxStarCount);
	}

}
