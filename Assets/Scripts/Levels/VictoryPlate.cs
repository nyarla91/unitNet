using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class VictoryPlate : Transformer
{
    [SerializeField] private Light2D _light;
    public int pressed;
    
    private void Start()
    {
        Levels.CurrentLevel.victoryPlates.Add(this);
    }

    private void Update()
    {
        if (pressed > 0)
        {
            _light.color = Color.green;
        }
        else
        {
            _light.color = Color.red;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals(Tags.UNIT))
        {
            Sound.Component.Play(Sound.Component.platePressed);
            pressed++;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals(Tags.UNIT))
        {
            Sound.Component.Play(Sound.Component.plateReleased);
            pressed--;
        }
    }
}
