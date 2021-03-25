using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{
    public static Controls Controls;
    public const float CellSize = 5;

    private void Awake()
    {
        Controls = new Controls();
        Controls.Game.Enable();
        Controls.Menu.Enable();
    }
}
