using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_update : MonoBehaviour
{
    public Text ScoreText;
    public int ScoreCount;
    int AddScore = 1;
    private GameObject GameManagerObj;
    private GameManager GameManagerScript;


    // Start is called before the first frame update
    void Start()
    {
        //Set the Text Count to Zero
        ScoreText.GetComponent<Text>();
        ScoreCount = 0;
        ScoreText.text = ScoreCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Player Collects the Star Successfully
    //Update the Score by 1
    public void UpdateScore ()
	{
        ScoreCount = (ScoreCount + AddScore) ;
        ScoreText.text = ScoreCount.ToString();
        Debug.Log("Function Update Score Called: And Score is: " + ScoreCount);

    }

    public void SaveScore(int scoreFinal)
	{
        //Save the Final Score to a file
        //Score overides the previous score


        /*GameManagerObj = GameObject.Find("GameManager");
        GameManagerScript = GameManagerObj.GetComponent<GameManager>();
        GameManagerScript.FinalGameScore = (ScoreCount + 1);*/


    }
}
