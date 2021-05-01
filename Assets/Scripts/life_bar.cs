using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class life_bar : MonoBehaviour
{
    public Slider LifebarSlider;
    public GameObject LifebarGreenUI;
    private Kill_Player KillplayerScript;
    private GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("UFO_Player");
        KillplayerScript = Player.GetComponent<Kill_Player>();
        Debug.Log("Slider Value: " + LifebarSlider.value);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //This Function will Reduce the Lifebar Based on the Kill Player Damage
    public void ReduceLifeBar () 
    {
        LifebarSlider.value = (LifebarSlider.value - KillplayerScript.UFODamageTaken);
        Debug.Log("Slider Value: " + LifebarSlider.value);
    }
}
