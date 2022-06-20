using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSquare : MonoBehaviour
{
    public int SquareIndex { get; set; }
    
    private Abecedario.LetterData _normalLetterData;
    private Abecedario.LetterData _selectedLetterData;
    private Abecedario.LetterData _correctLetterData;

    private SpriteRenderer _displayedImage;

    void Start()
    {
        _displayedImage = GetComponent<SpriteRenderer>();
    }

    
    public void SetSprite(Abecedario.LetterData normalLetterData, Abecedario.LetterData selectedLetterData, Abecedario.LetterData correctLetterData)
    {
        _normalLetterData = normalLetterData;
        _selectedLetterData = selectedLetterData;
        _correctLetterData = correctLetterData;

        GetComponent<SpriteRenderer>().sprite = _normalLetterData.image;
    }
}
