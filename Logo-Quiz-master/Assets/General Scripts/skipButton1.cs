using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skipBtn : MonoBehaviour
{ 

  public void Skip1()
  {

    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

  }

}
