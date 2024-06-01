using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NuseryRhymes : MonoBehaviour
{  
    [SerializeField] private AudioSource SelectSound;


   public void Rhyme1()
    {   
        SelectSound.Play();
        SceneManager.LoadScene("Rhyme1");
    }

    public void Rhyme2()
    {
        SelectSound.Play();
        SceneManager.LoadScene("Rhyme2");
    }
    public void Rhyme3()
    {   
        SelectSound.Play();
        SceneManager.LoadScene("Rhyme3");
    }
    public void Rhyme4()
    {
        SelectSound.Play();
        SceneManager.LoadScene("Rhyme4");
    }

    public void Rhyme5()
    {
        SelectSound.Play();
        SceneManager.LoadScene("Rhyme5");
    }

    public void Rhyme6()
    {
        SelectSound.Play();
        SceneManager.LoadScene("Rhyme6");
    }

    public void Rhyme7()
    {
        SelectSound.Play();
        SceneManager.LoadScene("Rhyme7");
    }

    public void Rhyme8()
    {
        SelectSound.Play();
        SceneManager.LoadScene("Rhyme8");
    }

    public void Rhyme9()
    {
        SelectSound.Play();
        SceneManager.LoadScene("Rhyme9");
    }
}
