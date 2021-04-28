using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_endScore : MonoBehaviour
{
    private GameObject ScoreCountObj;
    private score_update scoreUpdateScript;
    private Text EndScoreText;
    int ScoreEndVar;

    // Start is called before the first frame update
    void Start()
    {
        EndScoreText = gameObject.GetComponent<Text>();

        ScoreCountObj = GameObject.Find("scoreCount");
        scoreUpdateScript = ScoreCountObj.GetComponent<score_update>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateFinalEndScore ()
	{
        ScoreEndVar = scoreUpdateScript.ScoreCount;
        EndScoreText.text = ScoreEndVar.ToString();
        Debug.Log("Updating Score" + ScoreEndVar);

    }
    
}
