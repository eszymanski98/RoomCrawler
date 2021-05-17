using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour
{
    public void SceneLoader(string scenename)
    {
        SceneManager.LoadScene(scenename);
        Time.timeScale = 1f;
    }
    public void Continue()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame()
    {
        Debug.Log("Game has been closed.");
        Application.Quit();
    }
}