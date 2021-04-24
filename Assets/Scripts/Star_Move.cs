using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_Move : MonoBehaviour
{
    // Start is called before the first frame update

    public float StarSpeed;
    GameObject StarObj;
    private Rigidbody2D rb2dMove;
    public bool RBD2;

    void Start()
    {
        //Get a Position to appear from
        // Move the Star over the screen
        //Check for Collision with Player
        //Remove entity

        //rb2dMove = GetComponent<Rigidbody2D>();
        //rb2dMove.velocity = transform.right * StarSpeed;

    }

    // Update is called once per frame
    void Update()
    {
        //Move the Star in a Straight Line
        //transform.Translate((-0.01f*StarSpeed), 0, 0);

        gameObject.transform.position += new Vector3((StarSpeed * -1), 0, 0) * Time.deltaTime;

    }

    

}
