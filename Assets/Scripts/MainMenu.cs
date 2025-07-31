using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void NewGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ContinueGame()
    {
        Debug.Log("Load saved data...");       
    }

    public void Settings()
    {
        Debug.Log("Open settings menu...");
    }

    public void About()
    {
        Debug.Log("Show about screen...");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
