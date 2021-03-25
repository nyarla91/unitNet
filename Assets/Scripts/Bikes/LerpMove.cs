using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpMove : Transformer
{
    public Vector3 targetPosition;
    public float speed;
    private bool _inCanvas;

    protected override void Awake()
    {
        base.Awake();
        if (rectTransform != null)
        {
            _inCanvas = true;
        }
    }

    private void Update()
    {
        if (_inCanvas)
        {
            rectTransform.anchoredPosition = Vector3.Lerp(rectTransform.anchoredPosition, targetPosition, speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, speed * Time.deltaTime);
        }
    }
}
