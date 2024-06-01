using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMenu : MonoBehaviour
{ 

  [SerializeField] private AudioSource SelectSound;


  public void alphabet()
    {
      SelectSound.Play();
      SceneManager.LoadScene("AlphabetIntro");
    }

  public void words()
    {
      SelectSound.Play();
      SceneManager.LoadScene("spell game intro");
    }
}
