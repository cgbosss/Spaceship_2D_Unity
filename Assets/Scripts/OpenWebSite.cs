using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenWebSite : MonoBehaviour
{

    public Button WebButton;
    public string webURL = "https://www.getrevue.co/profile/weiqing_teh";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenURL(string websiteName)
	{
        Application.OpenURL(webURL);

    }
}
