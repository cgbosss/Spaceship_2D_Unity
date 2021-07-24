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
    private SpriteRenderer PlayerSprite;

    public int UFODamageTaken = 10;
    private int KillPlayerHealth;

    public GameObject PlayerLife_text;
    private score_playerLife PlayerUI;

    [Tooltip("checked for Game UI")]
    public GameObject GameUI;
    private pause_game PauseGameScript_UI;

    public GameObject LifeBar;
    private life_bar LifeBarScript;

    private Transform PlayerExplodeTrans;
    public GameObject PlayerExplodeObj;

    public GameObject HitPlayer;
    private AudioSource HitPlayerSound;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("UFO_Player");
        playerUFOScript = Player.GetComponent<Player_UFO>();

        //Get Player Health
        KillPlayerHealth = playerUFOScript.playerHealth;

        //Debug.Log("KillPlayer Check health " + PlayerHealth);

        LifeBar = GameObject.Find("Life_Bar");
        //Check for LifeBar is not NULL
        if (LifeBar!= null)
        {
            
            LifeBarScript = LifeBar.GetComponent<life_bar>();
        }
        else
        {
            LifeBar = null;
            LifeBarScript = null;
        }

        GameUI = GameObject.Find("Game_UI");
        
        //Check for UI Canvas / Player Life UI Null Checker
        if (GameUI != null)
		{
            PlayerLife_text = GameObject.Find("PlayerLifeScore");
            PlayerUI = PlayerLife_text.GetComponent<score_playerLife>();

            //Get the UI Canvas
            PauseGameScript_UI = GameUI.GetComponent<pause_game>();
            Debug.Log("Found the Player Life UI Canvas");
        }
        else
		{
            //Set the UI Canvas and Child Objects to NULL
            PlayerLife_text = null;
            GameUI = null;
            LifeBar = null;
            PlayerUI = null;
            Debug.Log("Set UI Canvas to NULL");
        }
        
        if(GameUI == false)
		{
            Debug.Log("Kill Start GameUI  ActiveInHierarchy is False");
		}

        HitPlayerSound = HitPlayer.GetComponent<AudioSource>();

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

            //Play Hit Explosion Animation and Sound.
            HitPlayerSound.Play();

        }
        if (KillPlayerHealth == 0)
		{
            Debug.Log("Kill Player and End Game");

            //Play Death Animation Sequence
            PlayerFinalDeath();

        }
    }


    public void reducePlayerLife()
	{
        //This Function will Reduce the Player Life
        

        Debug.Log("KillScript: Reduce Player Life");
        KillPlayerHealth = (KillPlayerHealth - UFODamageTaken);
        Debug.Log("New Current Health" + KillPlayerHealth);

        if(GameUI != false)
		{
            //Update the Lifebar UIs;
            PlayerUI.UpdateLifeCount();
            LifeBarScript.ReduceLifeBar();
        }
        else
		{
            Debug.Log("GameUI not Found Cannot Update LifeCount");
		}
        
        

    }


    public void PlayerFinalDeath()
	{
        //Get Transform of Player at current point and play Explosion Animation
        Debug.Log("Player Kill Final Death Animation Sequence");
        
        PlayerExplodeTrans = Player.transform;
        Instantiate(PlayerExplodeObj, PlayerExplodeTrans.position, PlayerExplodeTrans.rotation);

        PlayerSprite = Player.GetComponent<SpriteRenderer>();
        PlayerSprite.enabled = false;

        //Destroy(gameObject, 4.5f);

        //Send a Message to UI Canvas
        //showEndGameUIFunction();

    }

 

    private void showEndGameUIFunction() 
    {
        PauseGameScript_UI.EndGameMenu_Show();
    }
}
