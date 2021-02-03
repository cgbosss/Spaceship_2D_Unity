using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    public Button PlayButton;

    // Start is called before the first frame update
    void Start()
    {
        //PlayButton = GetComponent<Button>();
        PlayButton.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TaskOnClick()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have clicked the button!");
    }


    public void SceneLoader ()
	{
        SceneManager.LoadScene(0);
	}
}
