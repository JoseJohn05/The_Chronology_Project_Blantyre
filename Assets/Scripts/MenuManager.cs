using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject SettingsPanel;
    public GameObject AboutPanel;

    private const string SaveKey = "SavedScene";

    public void NewGame()
    {
        SceneManager.LoadScene("Introduction");
    }

    public void ContinueGame()
    {
        if (PlayerPrefs.HasKey(SaveKey)) 
        {
            string sceneToLoad = PlayerPrefs.GetString(SaveKey);
            SceneManager.LoadScene(sceneToLoad);
        }
        else 
        {
            Debug.LogWarning("There's no saved game.");
        }
    }

    public void OpenSettings() 
    {
        SettingsPanel.SetActive(true);
    }

    public void CloseSettings()
    {
        SettingsPanel.SetActive(false);
    }

    public void OpenAbout()
    {
        AboutPanel.SetActive(true);
    }

    public void CloseAbout()
    {
        AboutPanel.SetActive(false);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
