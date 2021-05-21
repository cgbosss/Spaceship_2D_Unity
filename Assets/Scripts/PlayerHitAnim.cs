using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitAnim : MonoBehaviour
{

    public Animation UFOAnimClips;
    public Animator UFOAnimator;
    private GameObject UFO_PlayerDeath;
    bool ShowHit = false;

    // Start is called before the first frame update
    void Start()
    {
        UFO_PlayerDeath = GameObject.Find("UFO_PlayerDeath");
        UFO_PlayerDeath.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //Function Show Hit for 1-2 Seconds and Set back to false
    public void HitActive ()
	{
        Debug.Log("Hit Active Animation Func Started");
        UFO_PlayerDeath.SetActive(true);

        UFOAnimator = UFO_PlayerDeath.GetComponent<Animator>();
        UFOAnimClips = UFO_PlayerDeath.GetComponent<Animation>();

        //UFOAnimClips.Play();
        UFOAnimator.Play("Base Layer.UFO_Hit", 1);
        Debug.Log("UFO Anim Playing" + UFOAnimClips.isPlaying);

        //Finish Playing Go Back to normal State

	}

}
