using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{   
    public static int scoreValue = 0;
    TMP_Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score :" + scoreValue;
    }
}
