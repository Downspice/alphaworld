using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class previousbtn : MonoBehaviour
{

public void previous()
{
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
}

}
