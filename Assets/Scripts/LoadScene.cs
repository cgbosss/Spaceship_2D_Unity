using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//This script controls the buttons inputs of the game menus
public class LoadScene : MonoBehaviour
{
    public Button PlayButton;
    public Button ReturnMenuButton;
    public Button QuitButton;

    //Use of enum to store various scenes
    public enum scene
	{
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sceneChange ()
	{
        Debug.Log("Scene Change!");
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
        SceneLoaderSingle(scene.Game_Scene);
        Debug.Log("You have clicked the button!" + scene.Game_Scene);
    }

    public void ReturnMenuFunc()
	{
        Debug.Log("You have clicked the button to Return Menu!");
        SceneLoaderSingle(scene.Start);
    }
    //This Function loads a single Scene 
    public void SceneLoaderSingle (scene sceneName)
	{
        SceneManager.LoadScene(sceneName.ToString(), LoadSceneMode.Single);
	}
}
