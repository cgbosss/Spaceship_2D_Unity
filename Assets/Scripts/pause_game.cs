using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause_game : MonoBehaviour
{
    public GameObject MenuType;

    // Start is called before the first frame update
    void Start()
    {
        print(MenuType);
        MenuType.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void PauseGame()
    {
        Time.timeScale = 0;
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
