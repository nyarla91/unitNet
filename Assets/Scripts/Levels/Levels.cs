using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    public static int CurrentLevelNumber;
    public static Level CurrentLevel;
    [SerializeField] private List<LevelProperties> _levelProperties;
    public static List<LevelProperties> LevelProperties;
    public static bool _restart;
    
    private void Awake()
    {
        Global.Controls.Game.Restart.performed += context => {Restartlevel();};
        LevelProperties = _levelProperties;
    }

    public static void LoadLevel(int level)
    {
        CurrentLevelNumber = level;
        if (level < LevelProperties.Count)
        {
            LoadScene("Game");
        }
        else
        {
            LoadScene("Menu");
        }
    }

    public static void Restartlevel()
    {
        _restart = true;
        LoadScene("Game");
    }

    private static void LoadScene(string name)
    {
        SceneManager.LoadScene(name, LoadSceneMode.Single);
    }
}

[Serializable]
public class LevelProperties
{
    public GameObject pefab;
    public Sprite tutorial;
    [TextArea(0,4)] public string tutorialText;
}
