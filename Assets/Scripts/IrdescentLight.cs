using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using Random = UnityEngine.Random;

public class IrdescentLight : MonoBehaviour
{
    [SerializeField] private Light2D _light;
    [SerializeField] private float _offset;
    [SerializeField] private bool _randomOffset = true;
    [SerializeField] private float _speed = 1;
    [SerializeField] private float _saturation = 1;

    private void Start()
    {
        if (_randomOffset)
        {
            _offset += Random.Range(0, 3);
        }
    }

    private void Update()
    {
        float sin = (Mathf.Sin(Time.time * _speed + _offset) + 1) / 2;
        _light.color = Color.HSVToRGB(sin, _saturation, 1);
    }
}
