using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LocalizedText : MonoBehaviour
{
    [SerializeField] private Text _textComponent;
    [SerializeField] private TextMesh _textMeshComponent;
    [Space]
    [SerializeField] private string _startingText;

    private void Awake()
    {
        SetText(Localization.Translate(_startingText));
    }

    private void SetText(string text)
    {
        if (_textComponent != null)
        {
            _textComponent.text = text;
        }

        if (_textMeshComponent.text != null)
        {
            _textMeshComponent.text = text;
        }
    }
}