using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause_game : MonoBehaviour
{
    public GameObject Start_UI;
    public GameObject Game_UI;
    public GameObject Pause_Menu_UI;
    bool showPauseMenu = false;

	/// <summary>
	/// This code is for the pause menu in game
	/// It controls the UI for the game.
	/// </summary>
	/// 

	// Start is called before the first frame update
	void Start()
    {
        Start_UI.SetActive(true);
        Game_UI.SetActive(true);
        Pause_Menu_UI.SetActive(true);
    }


	// Update is called once per frame
	void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape key was pressed Show Menu");
            PauseGame();
        }
        else if (Input.GetKeyDown(KeyCode.Tab))
        {
            ResumeGame();
            Debug.Log("Esc Key to Resume Game");

        }

    }

    void PauseGame()
    {
        Time.timeScale = 1;
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
    }

    //Send the Game back to the Main Menu
    public void ResumeGameBtn ()
	{
       
	}

    public void GameUI_Show ()
	{
        Game_UI.SetActive(true);
    }

    public void StartUI_Show ()
	{
        Start_UI.SetActive(true);
    }
}
