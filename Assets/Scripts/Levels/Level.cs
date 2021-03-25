using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public Vector2 offset;
    public List<VictoryPlate> victoryPlates;

    private void Awake()
    {
        transform.position += (Vector3) offset * Global.CellSize;
    }
}
