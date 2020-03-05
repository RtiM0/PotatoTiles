using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickingEventScript : MonoBehaviour
{
    public void StartBtn(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void QuitBtn(){
        Application.Quit();
    }
    public void AboutBtn(){
        SceneManager.LoadScene(3);
    }
    public void MainMenuBtn(){
        SceneManager.LoadScene(0);
    }
    public void RestartBtn(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }
}
