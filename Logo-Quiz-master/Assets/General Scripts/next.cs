using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class nextbtn : MonoBehaviour
{

public void next()
{   

    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    
    
}

}
