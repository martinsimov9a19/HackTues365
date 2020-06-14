using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenuScript : MonoBehaviour
{

    public void QuitGame()
    {
        Application.Quit();
    }

    public void FullScreen() {
        if (!Screen.fullScreen)
        {
   
            Screen.fullScreen = true;
            
        }
        else {

            Screen.fullScreen = !Screen.fullScreen;
            
        }
    }

}
