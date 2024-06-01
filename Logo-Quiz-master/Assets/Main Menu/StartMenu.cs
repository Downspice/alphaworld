using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
  public void play()
    {
      SceneManager.LoadScene("PlayMenu");
    }

  public void nursery()
    {
      SceneManager.LoadScene("NurseryRhymes");
    }
     
  public void stories()
    {
      SceneManager.LoadScene("Stories");
    } 
}
