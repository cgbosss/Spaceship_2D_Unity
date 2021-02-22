using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_update : MonoBehaviour
{
    public Text ScoreText;
    public int ScoreCount;
    
    // Start is called before the first frame update
    void Start()
    {
        //Set the Text Count to Zero
        ScoreText.GetComponent<Text>();
        ScoreCount = 0;
        ScoreText.text = "Star Count: ";
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Player Collects the Star Successfully
    //Update the Score by 1
    public void UpdateScore ()
	{
        ScoreCount = (ScoreCount + 1);
        ScoreText.text = ScoreCount.ToString();
        Debug.Log("Function Update Score Called");
	}
}
