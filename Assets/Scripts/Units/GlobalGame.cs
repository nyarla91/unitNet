using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalGame : MonoBehaviour
{
    [SerializeField] private Tutorial _tutorial;
    
    public List<Unit> units;
    public int currentControl;
    public int discarders;

    private bool _turnReady = true;
    private List<Coroutine> _turnCoroutines;
    private int _maxNumber;

    private void Awake()
    {
        units = new List<Unit>();
        _turnCoroutines = new List<Coroutine>();

        Global.Controls.Game.MoveLeft.performed += ctx => StartCoroutine(TryPerformTurn(Vector2.left));
        Global.Controls.Game.MoveRight.performed += ctx => StartCoroutine(TryPerformTurn(Vector2.right));
        Global.Controls.Game.MoveUp.performed += ctx => StartCoroutine(TryPerformTurn(Vector2.up));
        Global.Controls.Game.MoveDown.performed += ctx => StartCoroutine(TryPerformTurn(Vector2.down));
        Global.Controls.Game.ControlUp.performed += ctx => AddControl();
        Global.Controls.Game.DiscardControl.performed += ctx => DiscardControl();
        Global.Controls.Game.Menu.performed += ctx => { SceneManager.LoadScene("Menu", LoadSceneMode.Single);};
        InitLevel();
    }

    private void InitLevel()
    {
        Levels.CurrentLevel = Instantiate(Levels.LevelProperties[Levels.CurrentLevelNumber].pefab).GetComponent<Level>();
        if (Levels._restart || (Levels.LevelProperties[Levels.CurrentLevelNumber].tutorial == null))
        {
            Levels._restart = false;
            Destroy(_tutorial.gameObject);
        }
        else
        {
            _tutorial.LoadTutotial(Levels.LevelProperties[Levels.CurrentLevelNumber]);
        }
    }

    private IEnumerator TryPerformTurn(Vector2 direction)
    {
        if (_turnCoroutines.Count < 3)
        {
            Coroutine myTurn = StartCoroutine(PerformTurn(direction));
            _turnCoroutines.Add(myTurn);
            yield return new WaitForSeconds(0.35f);
            _turnCoroutines.Remove(myTurn);
        }
    }

    private IEnumerator PerformTurn(Vector2 direction)
    {
        yield return new WaitUntil(() => _turnReady);

        foreach (var unit in units)
        {
            unit.TryMove(direction, currentControl);
        }
        
        _turnReady = false;
        yield return new WaitForSeconds(0.34f);
        if (PlatesPressed())
        {
            Sound.Component.Play(Sound.Component.win);
            Levels.LoadLevel(Levels.CurrentLevelNumber + 1);
        }
        _turnReady = true;
    }

    public void AddUnit(Unit unit)
    {
        units.Add(unit);
        if (unit.number > _maxNumber)
        {
            _maxNumber = unit.number;
        }
    }

    private void AddControl()
    {
        foreach (var unit in units)
        {
            if (unit.number > currentControl)
            {
                Sound.Component.Play(Sound.Component.control);
                currentControl++;
                HighlightUnits();
                break;
            }
        }
    }

    private void DiscardControl()
    {
        if (discarders > 0)
        {
            discarders--;
            currentControl = 1;
        }
        HighlightUnits();
    }

    private void HighlightUnits()
    {
        foreach (var unit in units)
        {
            unit.TryHighlight(currentControl);
        }
    }

    private bool PlatesPressed()
    {
        foreach (var plate in Levels.CurrentLevel.victoryPlates)
        {
            if (plate.pressed == 0)
            {
                return false;
            }
        }
        return true;
    }

    private void OnDestroy()
    {
        Global.Controls.Game.MoveLeft.performed -= ctx => StartCoroutine(TryPerformTurn(Vector2.left));
        Global.Controls.Game.MoveRight.performed -= ctx => StartCoroutine(TryPerformTurn(Vector2.right));
        Global.Controls.Game.MoveUp.performed -= ctx => StartCoroutine(TryPerformTurn(Vector2.up));
        Global.Controls.Game.MoveDown.performed -= ctx => StartCoroutine(TryPerformTurn(Vector2.down));
        Global.Controls.Game.ControlUp.performed -= ctx => AddControl();
        Global.Controls.Game.DiscardControl.performed -= ctx => DiscardControl();
        Global.Controls.Game.Menu.performed -= ctx => { SceneManager.LoadScene("Menu", LoadSceneMode.Single);};
    }
}
