using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class score_playerLife : MonoBehaviour
{
    public Text PlayerLifeText;
    int PlayerHealth = 100;
    Player_UFO PlayerScript;

    // Start is called before the first frame update
    void Start()
    {
        //Set the Life Count to the Start
        PlayerLifeText = GetComponent<Text>();
        PlayerLifeText.text = PlayerHealth.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateLifeCount()
    {
        //PlayerScript.playerHealth.ToString();
    }
}
