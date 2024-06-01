using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backButton : MonoBehaviour
{
  public void back()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }
  
  public void backplaymenu()
    {
      SceneManager.LoadScene("PlayMenu");
    }
  
    public void backstartmenu()
    {
      SceneManager.LoadScene("StartMenu");
    }

  public void backmainmenu()
    {
      SceneManager.LoadScene("MainMenu");
    }

  public void backnurseryryhmes()
    {
      SceneManager.LoadScene("NurseryRhymes");
    }
  
  public void backstories()
    {
      SceneManager.LoadScene("Stories");
    }
    }
