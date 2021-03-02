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
    public enum scene
    {
        Start,
        Game_Scene,
    }



    //To Track the current Scene
    private string currentLevelName = string.Empty;

    //Use List to track the number of Async Operations cause don't know how many there are
    List<AsyncOperation> LoadOperations;

    // Start is called before the first frame update
    void Start()
    {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        //This will load the First Scene Main menu
        loadLevel("Start");
        DontDestroyOnLoad(gameObject);

        LoadOperations = new List<AsyncOperation>();

    }



    //This Function is to load the level Coroutine
    public void loadLevel(string levelName)
	{
        StartCoroutine(LoadYourAsyncScene(levelName));

        Debug.Log("Load Level Function Called");
        //Debug.Log("Active Scene : " + SceneManager.GetActiveScene().name);
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
            float progress = Mathf.Clamp01(AsyncLoad.progress / 0.9f);
            Debug.Log(progress);
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
        }

    }

    public void unloadLevel(string levelName)
	{
        AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);
        ao.completed += UnLoadOperationComplete;

        if (ao == null)
        {
            Debug.LogError("GameManager unable to UnLoad Level AO is Null" + levelName);
            return;
        }

    }

    IEnumerator UnLoadYourAsyncScene(string levelName)
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("Unloading the Scene...");
    }

        //End Game?
        public void EndGame()
    {

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
            //Dispatch Messages
            //or do Scene Transistions
            LoadOperations.Remove(ao);
            Debug.Log("Async Ops Removed ");
        }

        Debug.Log("UnLoad Completed");
    }


}
