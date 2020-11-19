using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavigation : MonoBehaviour
{
    public void GoHome()
    {
        SceneManager.LoadScene("HomeMenu");
    }

    public void LoadScreen()
    {
        SceneManager.LoadScene("LoadGame");
    }

    public void OptionsScreen()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

    public void EventScreen()
    {
        SceneManager.LoadScene("EventScreen");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    // Start is called before the first frame update
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
