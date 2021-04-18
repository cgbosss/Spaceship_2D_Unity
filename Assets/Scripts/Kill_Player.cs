using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Kill_Player : MonoBehaviour
{
    /// <summary>
    /// This Script Tracks the Player life and wheter to destory it
    /// </summary>
    /// 


    private GameObject Player;
    private Player_UFO playerUFOScript;
    public int UFODamage = 10;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("UFO_Player");
        playerUFOScript = Player.GetComponent<Player_UFO>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.tag == "rock")
        {
            //StartCoroutine(rockRemove());
            Debug.Log("UFO Has collided with " + collision.gameObject);
            reducePlayerLife();
        }
    }

    //
    public void reducePlayerLife()
	{
        //StartCoroutine( );
        Debug.Log("KillScript: Reduce Player Life");
    }
    //Coroutine Script to Kill the player Health after 0.5second

}
