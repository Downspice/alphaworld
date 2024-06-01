using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextRhyme : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

        public void previous()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
        }

        public void close()
        {
            SceneManager.LoadScene("NurseryRhymes");
        }
}
