using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetMoveCollide_Script : MonoBehaviour
{
    private float planetSpeed = -1;
    public Rigidbody2D rbPlanet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += Vector3.forward * Time.deltaTime;
        rbPlanet.velocity = transform.right * planetSpeed;
        //transform.Translate(Vector3.left * Time.deltaTime * planetSpeed);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        //planetSpeed = -3;
        //transform.Translate(Vector3.right * Time.deltaTime * planetSpeed);
        Debug.Log("Planet Collision Trigger " + other.ToString() +"_" + planetSpeed);

        Destroy(gameObject, 5f);
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
        Debug.Log("Trigger on Planet Activated");
        Destroy(gameObject, 5f);
    }

}
