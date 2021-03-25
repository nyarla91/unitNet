using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformer : MonoBehaviour
{
    public new Transform transform { get; protected set; }
    public RectTransform rectTransform { get; protected set; }

    protected virtual void Awake()
    {
        if (gameObject.transform != null)
        {
            transform = gameObject.transform;
        }

        if (GetComponent<RectTransform>() != null)
        {
            rectTransform = GetComponent<RectTransform>();
        }
    }
}
