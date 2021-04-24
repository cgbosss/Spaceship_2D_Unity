using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Rock : MonoBehaviour
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
    //public Transform SpwnPointTwo;
    public GameObject RockObj;
    public Vector3 NewStarVect;
    public int MaxStarCount;

    private bool SpawnStar = false;
    public float spawnDelay;
    public float spawnTime;

    // Start is called before the first frame update
    void Start()
    {
        MaxStarCount = 0;
        InvokeRepeating("spawnRock", 5f, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine(startSpawningStars());

        Debug.Log("Tracking The Count Stars" + MaxStarCount);

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

    IEnumerator startSpawningRocks()
    {
        yield return new WaitForSeconds(spawnDelay);

    }

    void spawnRock()
	{
        Instantiate(RockObj, SpwnPointOne.position, SpwnPointOne.rotation);
	}

    //Reset the Rock Count

}
