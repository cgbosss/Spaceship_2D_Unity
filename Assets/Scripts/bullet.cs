using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public Rigidbody2D rbBullet;
    public int bulletHitDamage = 1;

    [Tooltip("Prefab for Laser Hit Impact Explosion")]
    public GameObject LaserExp;
    private laser_exp LaserExpScript;

    public Transform LaserExpTrans;

    private GameObject RockExpObj;
    private AudioSource RockExpAudio;

    // Start is called before the first frame update
    void Start()
    {
        rbBullet.velocity = transform.right * bulletSpeed;
        //LaserExp = GameObject.Find("Hit-Yellow-sprite-sheet_LR");
        // LaserExpScript = LaserExp.GetComponent<laser_exp>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log("Laser collided with " + hitInfo.name);
        //Debug.Log("The Last Transform point" + LaserExpTrans.position);
        Destroy(gameObject, 3.3f);
        Instantiate(LaserExp, LaserExpTrans.position, LaserExpTrans.rotation);

        if (hitInfo.tag == "rock")
		{
            RockExpObj = GameObject.Find("LaserImpact");
            RockExpAudio = RockExpObj.GetComponent<AudioSource>();

            if (RockExpAudio.isPlaying == false)
			{
                RockExpAudio.Play();
			}
            else
			{
                RockExpAudio.Stop();
			}

            //Debug.Log("Found Rock and Playing the Hit Audio");
        }
    }

}
