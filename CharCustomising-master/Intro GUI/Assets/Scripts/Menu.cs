using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;

public class Menu : MonoBehaviour
{
    public bool showOptions;
    public bool start;
    public bool mainMenu;
    public bool exit;
    

    private void Start()
    {
      
    }

    public void toggleOptions()
    {
        
    }

    public void Update()
    {
        if(showOptions)
        {
            showOptions = false;
            mainMenu = true;
        }
        else
        {
            showOptions = true;
            mainMenu = false;
        }
    }

}
