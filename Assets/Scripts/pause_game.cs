using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause_game : MonoBehaviour
{
    public GameObject MenuType;
    public GameObject UI_Canvas;
    bool showPauseMenu = false;

    /// <summary>
    /// This code is for the pause menu in game
    /// </summary>
    /// 

    // Start is called before the first frame update
    void Start()
    {
        MenuType.SetActive(false);
        UI_Canvas.SetActive(false);
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
        MenuType.SetActive(true);
        UI_Canvas.SetActive(true);
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
        MenuType.SetActive(false);
    }

    //Send the Game back to the Main Menu
    public void ResumeGameBtn ()
	{
        MenuType.SetActive(false);
	}
}
