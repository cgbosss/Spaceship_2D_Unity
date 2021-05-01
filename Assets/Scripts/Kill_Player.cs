using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Kill_Player : MonoBehaviour
{
    /// <summary>
    /// This Script Tracks the Player life and destory it
    /// When Life is ZERO 0
    /// </summary>
    /// 


    private GameObject Player;
    private Player_UFO playerUFOScript;
    public int UFODamageTaken = 10;
    private int KillPlayerHealth;

    public GameObject PlayerLife_text;
    private score_playerLife PlayerUI;

    public GameObject UI_Canvas;
    private pause_game PauseGameScript_UI;

    public GameObject LifeBar;
    private life_bar LifeBarScript;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("UFO_Player");
        playerUFOScript = Player.GetComponent<Player_UFO>();

        //Check for LifeBar
        if (!LifeBar)
		{
            LifeBar = GameObject.Find("Life_Bar");
            LifeBarScript = LifeBar.GetComponent<life_bar>();
        }
        else
		{
            LifeBar = null;
            LifeBarScript = null;
		}


        //Get Player Health
        KillPlayerHealth = playerUFOScript.playerHealth;
        //Debug.Log("KillPlayer Check health " + PlayerHealth);

        //Check for UI Canvas Null Checker
        if (UI_Canvas != null)
		{
            PlayerUI = PlayerLife_text.GetComponent<score_playerLife>();

            //Get the UI Canvas
            PauseGameScript_UI = UI_Canvas.GetComponent<pause_game>();


        }
        else
		{
            PlayerLife_text = null;
            UI_Canvas = null;
            LifeBar = null;
        }
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
            Debug.Log("UFO Player Has collided with " + collision.gameObject);
            reducePlayerLife();

            //Play Explosion Animation and Sound.
        }
        if (KillPlayerHealth == 0)
		{
            Debug.Log("Kill Player and End Game");
            //Play Death Animation
            PauseGameScript_UI.EndGameMenu_Show();
            Destroy(gameObject, 4f);
		}
    }


    public void reducePlayerLife()
	{
        //This Function will Reduce the Player Life
        //Update the Lifebar UIs;

        Debug.Log("KillScript: Reduce Player Life");
        KillPlayerHealth = (KillPlayerHealth - UFODamageTaken);
        Debug.Log("New Current Health" + KillPlayerHealth);
        PlayerUI.UpdateLifeCount();
        LifeBarScript.ReduceLifeBar();
    }
    //Coroutine Script to Kill the player Health after 0.5second

}
