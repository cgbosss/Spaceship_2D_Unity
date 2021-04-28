using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public int rockLife;
    public float rockSpeed;
    private Rigidbody2D rb2d;

    private GameObject ufoPlayerObj;
    private Player_UFO PlayerUfoScript;
    private Kill_Player KillPlayerScript;

    Rock_explode RockExplodeScript;

    public float RockDestoryDelay;

    float GravityRandom;
    public float GravityMin = -0.10f;
    public float GravityMax = 0.50f;

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
        ufoPlayerObj = GameObject.Find("UFO_Player");

        if(ufoPlayerObj != null)
		{
            PlayerUfoScript = ufoPlayerObj.GetComponent<Player_UFO>();
		}
		else
		{
            ufoPlayerObj = null;
		}

        RockExplodeScript = gameObject.GetComponent<Rock_explode>();

        /*RockParticleExp.GetComponent<ParticleSystem>();
        Instantiate(RockParticleExp, rockTransformPosition.position, rockTransformPosition.rotation);
        RockParticleExp.Play();*/


        //Set the Gravity to a Random Range to help the Rock Float Up or Down.
        GravityRandom = Random.Range(GravityMin, GravityMax);
        Debug.Log("Rock Random Gravity: " + GravityRandom);
        rb2d.gravityScale = Mathf.Clamp(GravityRandom, -0.08f, 0.01f) ;
        //Debug.Log("Clamp" + rb2d.gravityScale.ToString());

        //Get a Random Speed for Rock
        rockSpeed = Random.Range(0.2f, 3f);
        Debug.Log("Rock Speed: " + rockSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
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
            //Call the Rock Explode Script
            RockExplodeScript.PlayExplosions();
            Destroy(gameObject, RockDestoryDelay);
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //Play Hit Animation and Reduce Life
        Debug.Log("Rock triggered with " + hitInfo.name + "reduceRockLife Remove Collided Object");
        //Destroy(hitInfo.gameObject, 1f);
        reduceRockLife();
        
    }

	void OnCollisionEnter2D(Collision2D collision)
	{
        Debug.Log("Rock Has collision Enter with " + collision.gameObject );	

        if (collision.gameObject.tag == "ScreenBound")
		{
            //StartCoroutine(rockRemove());
            Destroy(gameObject, 3.6f);
        }
        if (collision.gameObject.tag == "Player")
		{
            Debug.Log("Hit the Player and Remove a Life Kill Player");
            Destroy(gameObject, 2f);//Remove the Rock after 1-2 Second

        }
	}


}
