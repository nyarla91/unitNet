using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossScene : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
