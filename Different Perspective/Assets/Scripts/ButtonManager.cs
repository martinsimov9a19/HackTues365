using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class ButtonManager : MonoBehaviour
{
    public int LevelCount = 2;
    public void Menu() {
        SceneManager.LoadScene("MainMenu");

    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    public void NextLevel() {
        if (SceneManager.GetActiveScene().name != "Level" + LevelCount)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    public void PreviousLevel() {
        if (SceneManager.GetActiveScene().name != "Level1")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void FullScreen()
    {
        if (!Screen.fullScreen)
        {

            Screen.fullScreen = true;

        }
        else
        {

            Screen.fullScreen = !Screen.fullScreen;

        }
    }

    public void LoadLevel() {
        string name = gameObject.name;
        SceneManager.LoadScene(name);
    }
    public void LevelGenerateor() {
        SceneManager.LoadScene("LevelGeneator");
    }

}
