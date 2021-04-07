using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_UFO : MonoBehaviour
{
    //Initialize Player Properties
    public int playerHealth = 100;
    public float moveSpeed;
    public int playerAmmo = 50;

    private Rigidbody2D rb2d;
    //private AnimationClip ufoAnim;

    
    

    // Start is called before the first frame update
    void Start()
    {
        //Set the Initial Position
        //Move the Ship Up Down
        rb2d = GetComponent<Rigidbody2D> ();
        Debug.Log("Player Health Start" + playerHealth);


    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
	{
        //THis Codes uses Rigid Body for Moving a Player
        float moveHorizontal = Input.GetAxis("Horizontal");
        
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * moveSpeed);

    }

    //This Function Moves the Player
    void movePlayer ()
	{
        if (Input.GetKeyDown("a"))
        {
            print("A key was pressed");
        }
        if (Input.GetKeyDown("d"))
        {
            print("D key was pressed");
        }
        if (Input.GetKeyDown("w"))
        {
            print("w key was pressed");
        }
        if (Input.GetKeyDown("s"))
        {
            print("S key was pressed");
        }
        if (Input.GetKeyDown("space"))
        {
            print("Space key was pressed");
        }
    }
    
    void ReduceHealth()
	{
        playerHealth = -10;
        Debug.Log("Player Health " + playerHealth);
	}


}
