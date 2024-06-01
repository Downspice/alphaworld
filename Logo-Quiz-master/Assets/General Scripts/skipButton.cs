using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skipButton : MonoBehaviour
{ 

  public void Skip()
  {

    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

  }

}
