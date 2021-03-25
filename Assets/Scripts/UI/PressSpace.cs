using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressSpace : MonoBehaviour
{
    [SerializeField] private LerpMove _lerpMove;
    [SerializeField] private Image _space;
    [SerializeField] private Vector3 newPosition;
    
    private void Awake()
    {
        Global.Controls.Game.ControlUp.performed += ctx => StartCoroutine(Press());
    }

    private void Update()
    {
        if (_space != null)
        {
            _space.color = VectorHelper.SetA(_space.color, Mathf.Sin(Time.time * 3) * 0.4f + 0.6f);
        }
    }

    private IEnumerator Press()
    {
        _lerpMove.targetPosition = newPosition;
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        Global.Controls.Game.ControlUp.performed -= ctx => StartCoroutine(Press());
    }
}
