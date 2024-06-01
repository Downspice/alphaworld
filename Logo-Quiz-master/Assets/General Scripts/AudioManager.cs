using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    [Header("------------Audio Source-------")]
    public AudioSource musicSource;

    [Header("------------Audio Source-------")]
    public AudioClip background;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (Input.GetKeyDown(KeyCode.Space))
            if (musicSource.mute)
                musicSource.mute = false;
            else
                musicSource.mute = true;
    }

    void start()
    {
        musicSource.clip = background;
        musicSource.Play();

    }

}
