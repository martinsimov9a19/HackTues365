using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenuScript : MonoBehaviour
{

    public static Transform text;


    public void QuitGame()
    {
        Application.Quit();
    }

    public void FullScreen() {
        if (!Screen.fullScreen)
        {
            Debug.Log(text);
            
            Screen.fullScreen = true;
            
        }
        else {
            Debug.Log(text);
            
            Screen.fullScreen = !Screen.fullScreen;
            
        }
    }



}
