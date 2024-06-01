using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextGameSpell : MonoBehaviour
{
    public void Next()
    {
        SceneManager.LoadScene("Spell game");
    }
}
