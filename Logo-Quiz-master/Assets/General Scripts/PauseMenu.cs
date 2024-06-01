using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject CanvasMenu;


    // Update is called once per frame
    void Update()
    {
        
    }
    public void Pause()
    {
        CanvasMenu.SetActive(true);
        Time.timeScale = 0;

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
        ScoreScript.scoreValue =0;
    }

    public void Resume()
    {
        CanvasMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void Rewatch()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }

    public void Quit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
