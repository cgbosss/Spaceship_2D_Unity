using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Update the UI Scores for Player Life
/// </summary>

public class score_playerLife : MonoBehaviour
{
    public Text PlayerLifeText;
    int PlayerHealth = 110;
    public int DamagePoint = 10;
    //Player_UFO PlayerScript;
    //Kill_Player KillScript;

    public GameObject LifeBar;

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
        PlayerHealth = PlayerHealth - DamagePoint;
        Debug.Log("Current Player Life UI Count" + PlayerHealth);

        PlayerLifeText.text = PlayerHealth.ToString();
        Debug.Log("Player UI Health Reduce UpdateLifeCount");
    }

    public void UpdateLifeBar()
	{

	}
}
