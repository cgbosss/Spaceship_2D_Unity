using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//Star overlap with Player
//Star Collides with player 
//Play the disapearing animation
// Remove Object from Scene
//Update the Score


public class Star_Collision : MonoBehaviour
{

    public Transform ParticlePosition;
    public GameObject ParticleWinObject;
    private GameObject scoreCountUI;
    private score_update scoreUpdateScript;
    private AudioSource StarWinSound;

    public Spawner spawnerScript;

	void Start()
	{
        
        //Set the Game Object to Var
        scoreCountUI = GameObject.Find("scoreCount");

        //Checker for GameObject is not NULL
        if (scoreCountUI != null)
		{
            Debug.Log("Found Score Count: " + scoreCountUI);

            //Need to get Componenet of the other GameObject Script before accessing the Function
            scoreUpdateScript = scoreCountUI.GetComponent<score_update>();
            Debug.Log("Found Component Script: " + scoreUpdateScript);
        }

        else
		{
            scoreCountUI = null;
            Debug.Log("No Score UI Found");
		}
        



        StarWinSound = GetComponent<AudioSource>();
        
	}

	// Update is called once per frame
	void Update()
    {
       
    }



    void OnCollisionEnter2D(Collision2D col2d)
    {
        Debug.Log("Star is colliding" + col2d.gameObject.name);
        if (col2d.gameObject.tag == "Player")
        {
            Debug.Log("Make Star Disapear, Update the Score");
            Destroy(gameObject, 1.0f); // This gives a delay to the object being removed

            GameObject CloneParticle = Instantiate(ParticleWinObject, ParticlePosition.position, ParticlePosition.rotation);
            Destroy(CloneParticle, 3f);// Delete the particles after displaying


            StarWinSound.PlayDelayed(0.01f);
            //This will updated the Score based on the Score Update Fuction in another script
            if (scoreUpdateScript != null)
			{
                scoreUpdateScript.UpdateScore();
			}

            //Disappear();
            //PlayParticle Animation to Win()
            //col2d.gameObject.SendMessage("ApplyDamage", 10

        }
        else if (col2d.gameObject.name == "Left_End_Boundry") 
        {
            Debug.Log("Star Hit the Bounds");
        }


    }

    void OnCollisionExit2D(Collision2D col2d)
	{
        //scoreUpdateScript.UpdateScore();

        if(col2d.gameObject.tag == "ScreenBound") 
        {
            Debug.Log("Remove Star from Scene");
        }
        else if (col2d.gameObject.CompareTag("ScreenBound"))
        {
            Debug.Log("Remove Collided Object from Scene");
            Destroy(gameObject, 1.0f);
        }
    }

}
