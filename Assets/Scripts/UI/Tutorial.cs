using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Text _text;

    public void LoadTutotial(LevelProperties level)
    {
        _image.sprite = level.tutorial;
        _text.text = level.tutorialText;
    }
}
