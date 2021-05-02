using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser_exp : MonoBehaviour
{
    public Animator ExplodeSpriteAnim;
    public GameObject HitYellowObj;

    [Tooltip("Float Delay for Removing the Animation")]
    public float delayAnim;

    // Start is called before the first frame update
    void Start()
    {
        ExplodeSpriteAnim = gameObject.GetComponent<Animator>();

        //ExplodeSpriteAnim.gameObject.SetActive(false);

        PlayHitExplosion();
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayHitExplosion()
	{
        Debug.Log("Playing Laser Explode Sprite");

        ExplodeSpriteAnim.enabled = true;
        ExplodeSpriteAnim.Play("Base Layer.Explode", 0, 0.2f);

        Destroy(gameObject, delayAnim);
        
    }
}
