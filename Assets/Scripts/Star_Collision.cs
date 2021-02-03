using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_Collision : MonoBehaviour
{

    public Transform ParticlePosition;
    public GameObject ParticleWinObject;

    // Update is called once per frame
    void Update()
    {
        
    }

    //Star overlap with Player
    //Star Collides with player 
    //Play the disapearing animation
    // Remove Object from Scene
    //Update the Score

    void OnCollisionEnter2D(Collision2D col2d)
    {
        Debug.Log("We are colliding" + col2d.gameObject.name);
        if (col2d.gameObject.tag == "Player")
        {
            Debug.Log("Make Star Disapear, Update the Score");
            Destroy(gameObject, 1.0f); // This gives a delay to the 
            GameObject CloneParticle = Instantiate(ParticleWinObject, ParticlePosition.position, ParticlePosition.rotation);

            Destroy(CloneParticle, 3f);// Delete the particles after displaying

            //Disappear();
            //PlayParticle Animation to Win()
            //col2d.gameObject.SendMessage("ApplyDamage", 10);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject);

        if (collision.gameObject.name == "UFO_Player")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Star Collied Do something here");
        }
        if (collision.gameObject.name == "bg")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Star Collied with BG Do something here");
        }
    }
}
