using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameController : MonoBehaviour
{
    
    public char Letter = 'a';
    
    int _correctAnswers = 5;
    int _correctClicks;
    
    public static GameController Instance { get; private set; }

    public AudioSource src;
    

    public AudioClip correctAnswer, wrongAnswer, miniCompleted;

    void Awake()
    {
        Instance = this;
        src = GetComponent<AudioSource>();
        
    }

    void OnEnable()
    {
        GenerateBoard();
        UpdateDiplayLetters();
    }

    void GenerateBoard()
    {
        var clickables = FindObjectsOfType<ClickableLetter>();

        List<char> charsList = new List<char>();

        for (int i = 0; i < _correctAnswers; i++)
            charsList.Add(Letter);

        for (int i = _correctAnswers; i < clickables.Length; i++)
        {
            var chosenLetter = ChooseInvalidRandomLetter();
            charsList.Add(chosenLetter);
        }

        charsList = charsList
            .OrderBy(t => UnityEngine.Random.Range(0, 10000))
            .ToList();

        for (int i = 0; i < clickables.Length; i++)
        {
            clickables[i].SetLetter(charsList[i]);
        }

        FindObjectOfType<RemainingCounterText>().SetRemaining(_correctAnswers - _correctClicks);
    }

    internal void HandleCorrectLetterClick(bool upperCase)
    {
         
        _correctClicks++;
        FindObjectOfType<RemainingCounterText>().SetRemaining(_correctAnswers - _correctClicks);
        if (_correctClicks >= _correctAnswers)
        {
            MoveToNextLetter();
            UpdateDiplayLetters();
            _correctClicks = 0;
            GenerateBoard();
            
        }
        src.clip= correctAnswer;
        src.Play();
    }
        internal void HandleWrongLetterClick(bool upperCase)
    {
         
        _correctClicks++;
        FindObjectOfType<RemainingCounterText>().SetRemaining(_correctAnswers - _correctClicks);
        if (_correctClicks < _correctAnswers)
        {

        src.clip= wrongAnswer;
        src.Play();
            
        }

    }

    private void MoveToNextLetter()
    {
        Letter++;
        src.clip =miniCompleted;
        src.Play();

    }

    private void UpdateDiplayLetters()
    {
        foreach (var displayletter in FindObjectsOfType<DisplayLetter>())
        {
            displayletter.SetLetter(Letter);
        }
    }

    private char ChooseInvalidRandomLetter()
    {
        int a = UnityEngine.Random.Range(0, 26);
        var randomLetter = (char)('a' + a);
        while (randomLetter == Letter)
        {
            a = UnityEngine.Random.Range(0, 26);
            randomLetter = (char)('a' + a);
        }

        return randomLetter;
    }
}