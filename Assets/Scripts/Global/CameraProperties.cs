using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraProperties : MonoBehaviour
{
    public static Vector3 mousePosition
    {
        get
        {
            return Camera.main.ScreenToWorldPoint(Global.Controls.Menu.MousePosition.ReadValue<Vector2>());
        }
    }

    public static Vector3 NaturalToWorldPoint(Vector2 natural)
    {
        natural += Vector2.one;
        natural /= 2;
        natural *= new Vector2(Screen.width, Screen.height);
        return Camera.main.ScreenToWorldPoint(natural);
    }
}
