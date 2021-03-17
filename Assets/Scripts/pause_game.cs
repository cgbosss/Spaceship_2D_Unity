﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause_game : MonoBehaviour
{
    public GameObject Start_UI;
    public GameObject Game_UI;
    public GameObject Pause_Menu_UI;

    private GameObject GameManagerObj;
    private GameManager GameManagerScript;
    
    bool showPauseMenu = false;

    public enum GameScenes
    {
        Start,
        Game_Scene,
        End_Scene
    }

    /// <summary>
    /// This code is for the pause menu in game
    /// It controls the UI for the game.
    /// </summary>
    /// 

    // Start is called before the first frame update
    void Start()
    {
        /*
        Start_UI.SetActive(false);
        Game_UI.SetActive(false);
        Pause_Menu_UI.SetActive(true);
        */
        PauseUI_Hide();
        GameManagerObj = GameObject.Find("GameManager");
        GameManagerScript = GameManagerObj.GetComponent<GameManager>();
        
    }


	// Update is called once per frame
	void Update()
    {

        //Code to check for Escape Key Menus
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape key was pressed Show Menu and Set to True Pause Menu");
            if (showPauseMenu == false)
            {
                PauseGame();
                PauseUI_Show();
                showPauseMenu = true;
            }
            else
			{
                ResumeGame();
                PauseUI_Hide();
                showPauseMenu = false;
			}


        }
        /*else if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            
        }*/

        //UI Display
        Debug.Log("Pause_Game Call Var:" + GameManagerScript.currentLevelName);
        DisplayUIbyScene(GameManagerScript.currentLevelName);
    }

    public void DisplayUIbyScene(string levelName)
	{
        if (levelName == GameScenes.Start.ToString() )
        {
            Debug.Log("Show only Start UI");
            StartUI_Show();
            GameUI_Hide();
            PauseUI_Hide();
        }
        
        if (levelName == GameScenes.Game_Scene.ToString() )
		{
            Debug.Log("Show Only Game UI");

            StartUI_Hide();
            GameUI_Show();
        }

        if (levelName == GameScenes.End_Scene.ToString())
        {
            Debug.Log("Show Only EndScene");
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

    public void GameUI_Show ()
	{
        Game_UI.SetActive(true);
    }

    public void GameUI_Hide()
    {
        Game_UI.SetActive(false);
    }

    public void StartUI_Show ()
	{
        Start_UI.SetActive(true);
    }
    public void StartUI_Hide()
    {
        Start_UI.SetActive(false);
    }

    public void PauseUI_Show()
	{
        Pause_Menu_UI.SetActive(true);
	}

    public void PauseUI_Hide()
    {
        Pause_Menu_UI.SetActive(false);
    }


}
