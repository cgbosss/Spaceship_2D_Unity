using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is used to call the Scriptable Object
/// Data from the Asset Folder
/// </summary>
public class GamePoints_Func : MonoBehaviour
{
    //Attach the Scriptable Object to a Game Object in Editor
    public GamePoints GameData;

    public int CurrentPoints;
    public int ZeroPoints = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Set the Game Points to Zero on Start
        GameData.GamePointsTrack = ZeroPoints;

        //Debug.Log("First Game Data  " + GameData.GamePointsTrack);

        //GameData.GamePointsTrack = ZeroPoints;
        Debug.Log("GameData Start" + GameData.GamePointsTrack);
        //GameData.AddPoints(12);

        //Debug.Log("New GameData SO " + GameData.GamePointsTrack);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetGamePointsResults ()
	{
        CurrentPoints = GameData.GamePointsTrack;
        Debug.Log("Get GameData Points Func Result" + CurrentPoints);
	}

    public void ResetGameScore ()
	{
        GameData.GamePointsTrack = ZeroPoints;
        Debug.Log("GameData SO has be reset " + GameData.GamePointsTrack);
    }
}
