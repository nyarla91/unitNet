using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class Unit : Transformer
{
    [SerializeField] private TextMesh _numberText;
    [SerializeField] private Light2D _highlight;
    public int number;
    
    private GlobalGame _globalGame;
    private Coroutine _moveCoroutine;

    protected override void Awake()
    {
        base.Awake();
        _globalGame = FindObjectOfType<GlobalGame>();
        _globalGame.AddUnit(this);
        _numberText.text = $"{number}";
    }

    public void TryMove(Vector2 direction, int control)
    {
        _moveCoroutine = StartCoroutine(Move(direction, control));
    }

    public IEnumerator Move(Vector2 direction, int control)
    {
        if (number > control)
        {
            _moveCoroutine = null;
            yield break;
        }
        Vector3 targetPoint = transform.position + (Vector3) direction * Global.CellSize;
        while (Vector2.Distance(transform.position, targetPoint) > 0.05f)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPoint, Time.deltaTime * 45);
            yield return null;
        }
        transform.position = targetPoint;
        _moveCoroutine = null;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals(Tags.DEADLY))
        {
            Die();
        }
        if (_moveCoroutine != null)
        {
            StopCoroutine(_moveCoroutine);
            transform.position = VectorHelper.SetZ(VectorHelper.SnapToGrid
            (
                transform.position, Vector2.one * 5, (Vector2.one * 2.5f)),
            -10);
        }
    }

    public void TryHighlight(int control)
    {
        _highlight.enabled = control == number;
    }

    private void Die()
    {
        Sound.Component.Play(Sound.Component.lose);
        Levels.Restartlevel();
    }
}
