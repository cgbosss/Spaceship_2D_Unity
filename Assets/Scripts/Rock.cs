using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public int rockLife;
    public float rockSpeed;
    private Rigidbody2D rb2d;

    private GameObject ufoPlayer;

    public GameObject RockParticleExp;
    

    /// <summary>
    /// Rock Script to move the rock
    /// Update the player life on impact
    /// Destory Rock on Impact
    /// </summary>

    // Start is called before the first frame update
    void Start()
    {
        //Get the Rock RB
        rb2d = GetComponent<Rigidbody2D>();
        //Debug.Log("Rock Life Start" + rockLife);
        ufoPlayer = GameObject.Find("UFO_Player");
        Debug.Log("Ufo Player : " + ufoPlayer.name);

    }

    // Update is called once per frame
    void Update()
    {
        //get a random number between 1-10
    }

	void FixedUpdate()
	{
        Vector2 movement = new Vector2(-2, 0);
        rb2d.AddForce(movement * rockSpeed);
    }
	//This function is to reduce the Rock life and delete it
	public void reduceRockLife()
	{
        rockLife = (rockLife -1);
        Debug.Log("Reduce Rock Life" + rockLife);
        if(rockLife == 0)
		{
            Debug.Log("Destory the Rock");
            Destroy(gameObject);
		}
	}

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //Play Hit Animation and Reduce Life
        Debug.Log("Rock triggered with " + hitInfo.name + "reduceRockLife");
        Destroy(hitInfo.gameObject, 1f);
        reduceRockLife();
        
    }

	void OnCollisionEnter2D(Collision2D collision)
	{
        Debug.Log("Rock Has collided with " + collision.gameObject );	

        if (collision.gameObject.tag == "ScreenBound")
		{
            //StartCoroutine(rockRemove());
            Destroy(gameObject, 3f);
        }
        if (collision.gameObject.tag == "Player")
		{
            Debug.Log("Hit the Player and Remove a Life");
		}
	}

    IEnumerator rockRemove()
    {
        //play your sound
        yield return new WaitForSeconds(3); //waits 3 seconds
        Destroy(gameObject); //this will work after 3 seconds.
    }
}
