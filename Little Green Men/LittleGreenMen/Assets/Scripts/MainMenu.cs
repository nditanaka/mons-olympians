using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void GoHome()
    {
        SceneManager.LoadScene("HomeMenu");
    }

    public void QuitGame()
    {
        UnityEngine.Debug.Log("App has been quit");
        //Application.Quit;
    }
}
