using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GamePoints_SO", menuName = "SO/GamePoints Vars", order = 1)]
public class GamePoints : ScriptableObject
{
	#region Var SO
	public bool savePoints = false;

    public int GamePointsTrack;
    public int PlayerMaxLife = 100;

	#endregion
	//public GameSetPoints SetPoints { get; private set; }

	#region AddPoints
	public void AddPoints(int currentPoints)
	{
		GamePointsTrack = +currentPoints;
		Debug.Log("Add Poins SO added " + GamePointsTrack);
	}
	#endregion

}

