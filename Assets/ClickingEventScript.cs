using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickingEventScript : MonoBehaviour
{
    public void StartBtn(){
        SpawnerAction.delay = 1f;
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
        SpawnerAction.delay=1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }
}
