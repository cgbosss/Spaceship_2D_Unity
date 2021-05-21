using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_endScore : MonoBehaviour
{
    private GameObject ScoreCountObj;
    private score_update scoreUpdateScript;
    public Text EndScoreText;
    int ScoreEndVar = 0;
    bool EndUIShow = false;

    public GamePoints GameData;
    public GamePoints_Func GamePointsScript;

    // Start is called before the first frame update
    void Start()
    {
        ScoreCountObj = GameObject.Find("scoreCount");

        if(ScoreCountObj != null)
		{
            scoreUpdateScript = ScoreCountObj.GetComponent<score_update>();
		}
        else
		{
            ScoreCountObj = null;
            Debug.Log("Game End Score cannot Find the Final Score Object");
		}

        //Debug.Log("Updating Final End Game ScoreUpdateScript VAR:" + scoreUpdateScript.FinalScore.ToString());

        //UpdateFinalEndScore();

        //Set the Scriptable Object
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateFinalEndScore ()
	{
        //ScoreEndVar = 12;
        //ScoreEndVar = ScoreEndVar + scoreUpdateScript.FinalScore;
        //ScoreEndVar = scoreUpdateScript.FinalScore;

        EndUIShow = true;
        
        Debug.Log("Updating Final End Game Score Funct");
        GamePointsScript.GetGamePointsResults();
        ScoreEndVar = GamePointsScript.CurrentPoints;

        Debug.Log("The New Score End Points are" + ScoreEndVar);

        //Search for the UI to Update
        EndScoreText = gameObject.GetComponent<Text>();
        EndScoreText.text = ScoreEndVar.ToString();

        //After Display Set the Game Object Back to Zero
    }

}
