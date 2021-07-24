using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitAnim : MonoBehaviour
{

    public Animation UFOAnimClips;
    private GameObject UFO_PlayerDeath;
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
}
