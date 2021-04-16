using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Game Manager for the Game
    //Track the Game State Am I playing the game or not?
    //Load Game Levels and Unload Levels
    //Check game is not over (Player Life 0) if over give the option to restart
    //End the Game and unload all Level (Quit
    /*public enum scene
    {
        Start,
        Game_Scene,
        End_Scene
    }*/

    public enum GameState
	{
        Start,
        PlayingLevel,
        Finished,
	}

    bool ActiveSceneSet;
    public Scene ActiveScene;
    private GameObject UICanvas;
    private pause_game PauseGameScript;
    public int FinalGameScore;

    //To Track the current Scene
    public string currentLevelName = string.Empty;

    //Use List to track the number of Async Operations cause don't know how many there are
    List<AsyncOperation> LoadOperations;

    //public Scene currentScene;

    // Start is called before the first frame update
    void Start()
    {
        FinalGameScore = 0;
        //This will load the First Scene Main menu
        loadLevel("Start");
        DontDestroyOnLoad(gameObject); //Do Not Destory the Game Manager
        
        LoadOperations = new List<AsyncOperation>();

    }

    // Update is called once per frame
    void Update()
    {
        //Check the Game State
        CheckGameState();
    }

    //This Function is to load the level Coroutine
    public void loadLevel(string levelName)
	{
        StartCoroutine(LoadYourAsyncScene(levelName));
        Debug.Log("LoadAsync Active Scene Start: " + SceneManager.GetActiveScene().name);

        //Load the UI here based on LevelName
        /*if(levelName == "Start")
		{
            Debug.Log(levelName + " LoadLevel the Start UI here");
        }*/

    }

    IEnumerator LoadYourAsyncScene(string levelName)
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("Load Your Async Started...");
        AsyncOperation AsyncLoad = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);
        //AsyncLoad.completed += OnLoadOperationComplete; //This will register the AsyncOps to the function
        currentLevelName = levelName;
        LoadOperations.Add(AsyncLoad);

        //Check if there is such a level in Async Ops Give Error message
        if (AsyncLoad == null)
        {
            Debug.LogError("GameManager unable to Load Level AsynOperation is Null" + levelName);
            yield return null;
        }

        // Wait until the asynchronous scene fully loads
        while (!AsyncLoad.isDone)
        {
            float progress = Mathf.Clamp01(AsyncLoad.progress / 0.9f); //Convert 0.9 of Progress to 1
            Debug.Log("Progress" + progress);
            yield return null;
        }

        //Remove any Async Ops from the List when the load is done
        //Do other Checking here
        if (AsyncLoad.isDone)
		{
            Debug.Log("Load Async is finished");
            LoadOperations.Remove(AsyncLoad);
            Debug.Log("LD OPS:-" + LoadOperations.Count);
            Debug.Log("Current Level: " + currentLevelName);


            //Check for UI Canvas
            UICanvas = GameObject.Find("UI_Canvas");
            Debug.Log("Game Manager Object UICanvas " + UICanvas.name);
            PauseGameScript = UICanvas.GetComponent<pause_game>();

            /*if (UICanvas != null)
            {
                Debug.Log("GameManager Found UI Canvas" + UICanvas);
            }*/

            ActiveSceneSet = true;

            //Set the Variable CurrentScene to the Active Scene
            if (ActiveSceneSet == true)
			{
                SceneManager.SetActiveScene(SceneManager.GetSceneByName(currentLevelName));
                Debug.Log("ActiveScene Scene  " + SceneManager.GetActiveScene().name);
            }
            else
			{
                ActiveSceneSet = false;
			}
        }

    }

    public void unloadLevel(string levelName)
	{
        StartCoroutine(UnLoadYourAsyncScene(levelName));
    }

    IEnumerator UnLoadYourAsyncScene(string levelName)
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("Unloading the Scene...");
        AsyncOperation AsyncUnLoad = SceneManager.UnloadSceneAsync(levelName);

        if (AsyncUnLoad == null)
        {
            Debug.LogError("GameManager unable to UnLoad Level AO is Null" + levelName);
            yield return null;
        }

        //Reset the Variables for Active Scene and level Name
        while (!AsyncUnLoad.isDone)
        {
            currentLevelName = string.Empty;
            ActiveSceneSet = false;

            yield return null;
        }

    }

    public void unloadLevelao (string levelName)
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);
        ao.completed += UnLoadOperationComplete;

        if (ao == null)
        {
            Debug.LogError("GameManager unable to UnLoad Level AO is Null" + levelName);
            return;
        }

    }


    //End Game?
    public void CheckGameState()
    {
        //This function runs when the Game has ended 
        //Life is 0 for player
        //Display the Final Score and Button to go back to Menu and Restart the Game
        Debug.Log("GameState is to" + currentLevelName + GameState.Start);
    }

    //This is to check if the loading is complete and clear any Async
    /*void OnLoadOperationComplete(AsyncOperation ao) 
    {
        if (LoadOperations.Contains(ao) )
		{
            //Dispatch Messages
            //or do Scene Transistions
            LoadOperations.Remove(ao);
            Debug.Log("Async Ops Removed ");
		}
        Debug.Log("Load Completed");
    }*/

    void UnLoadOperationComplete(AsyncOperation ao)
    {
        if (LoadOperations.Contains(ao))
        {
            //Dispatch Messages or do Scene Transistions
            LoadOperations.Remove(ao);
            Debug.Log("Async Ops Removed ");
        }

        Debug.Log("GameManager UnLoad Completed");
    }


}
