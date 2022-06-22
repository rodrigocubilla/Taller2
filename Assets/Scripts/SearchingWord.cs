using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SearchingWord : MonoBehaviour
{

    public TextMeshProUGUI displayedText;
    [SerializeField] private Image crossLine;

    private string _word;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private  void OnEnable() 
    {
        GameEvents.OnCorrectWord += CorrectWord;
    }

    private void OnDisable() 
    {
        GameEvents.OnCorrectWord -= CorrectWord;
    }

    public void SetWord(string word)
    {
        _word = word;
        displayedText.text = word;
    }

    private void CorrectWord(string word, List<int> squareIndexes)
    {
        if(word == _word)
        {
            crossLine.gameObject.SetActive(true);
        }
    }
}
