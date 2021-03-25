using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{

    private void Awake()
    {
        Global.Controls.Menu.Press.performed += ctx => Press();
    }

    private void Press()
    {
        if (Vector2.Distance(CameraProperties.mousePosition, transform.position) <= 4)
        { 
            Application.Quit();
        }
    }
}
