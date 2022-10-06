using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using PixelCrushers.DialogueSystem;

public class MainMenu : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void NewGame()
    {
        PixelCrushers.SaveSystem.LoadScene("�}���ʵe");
        //SceneManager.LoadScene("�}���ʵe");
    }
}
