using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//This script controls the buttons inputs of the game menus
public class ButtonScripts : MonoBehaviour
{
    public Button PlayButton;
    public Button ReturnMenuButton;
    public Button QuitButton;

    private GameObject GameManagerObj;
    private GameManager GameManagerScript;

    //Use of enum to store various scenes
    public enum scene
	{
        Boot,
        Start,
        Game_Scene,
	}


    // Start is called before the first frame update
    void Start()
    {
        //PlayButton = GetComponent<Button>();
        PlayButton.onClick.AddListener(PlayBtnOnClick);
        ReturnMenuButton.onClick.AddListener(ReturnMenuFunc);
        QuitButton.onClick.AddListener(quitGame);

        //Setup Communication with the Game Manager
        GameManagerObj = GameObject.Find("GameManager");

        if (GameManagerObj != null)
        {
            Debug.Log("Button Script Found Game Manager " + GameManagerObj.name);

            GameManagerScript = GameManagerObj.GetComponent<GameManager>();

        }
        else
        {
            Debug.Log("GameManager Not Found");
            GameManagerObj = null;
            GameManagerScript = null;
        }


    }


    void quitGame()
	{
        //Quit the Game
        Application.Quit();
        Debug.Log("Quit App!");
	}

    //Code to load the Game from PlayButton
    void PlayBtnOnClick()
    {
        Debug.Log("Play BTN Clicked");
        GameManagerScript.unloadLevel("Start");
        GameManagerScript.loadLevel("Game_Scene");
    }

    //Return to the Main Menu
    public void ReturnMenuFunc()
	{
        Debug.Log("You have clicked the button to Return Menu!");
        GameManagerScript.unloadLevel("Game_Scene");
        GameManagerScript.loadLevel("Start");

    }

    //This Function loads a single Scene 
    public void SceneLoaderSingle(scene sceneName)
	{
        SceneManager.LoadScene(sceneName.ToString(), LoadSceneMode.Single);
	}
}
