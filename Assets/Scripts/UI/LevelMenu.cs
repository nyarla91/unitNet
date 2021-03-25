using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMenu : MonoBehaviour
{
    [SerializeField] private TextMesh _number;
    [SerializeField] private int _level;

    private void Awake()
    {
        _number.text = $"{_level}";
        Global.Controls.Menu.Press.performed += ctx => Press();
    }

    private void Press()
    {
        if (Vector2.Distance(CameraProperties.mousePosition, transform.position) <= 4)
        {
            Levels.LoadLevel(_level);
        }
    }

    private void OnDestroy()
    {
        Global.Controls.Game.ControlUp.performed -= ctx => Press();
    }
}
