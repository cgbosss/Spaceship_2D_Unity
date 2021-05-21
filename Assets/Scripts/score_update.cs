using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_update : MonoBehaviour
{
    public Text ScoreText;
    public int ScoreCount;

    public int FinalScore;

    int AddScore = 1;
    private GameObject GameManagerObj;
    private GameManager GameManagerScript;

    public GameObject EndGameScoreObj;
    public game_endScore EndGameScoreScript;

    //Get the Scritable object
    public GamePoints GameData;

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
        ScoreCount = (ScoreCount + AddScore);
        ScoreText.text = ScoreCount.ToString();
        Debug.Log("Function Update Score Called: And Score is: " + ScoreCount);
        
        FinalScore = ScoreCount;
        Debug.Log("Score Update Final Score Var : " + FinalScore);

        GameData.AddPoints(ScoreCount); // Use the Update Function in the Sriptable Object
}

    public void SaveScore(int scoreFinal)
	{
        //Save the Final Score to the scriptable object
        //Score overides the previous score


        /*GameManagerObj = GameObject.Find("GameManager");
        GameManagerScript = GameManagerObj.GetComponent<GameManager>();
        GameManagerScript.FinalGameScore = (ScoreCount + 1);*/


    }


}
