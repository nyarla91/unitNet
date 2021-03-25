using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberHelper : MonoBehaviour
{
    public static void Normalize(ref float value)
    {
        value = Normalize(value);
    }

    public static float Normalize(float value)
    {
        if (value > 0)
        {
            value = 1;
        }
        else if (value < 0)
        {
            value = -1;
        }
        return value;
    }

    public static bool Even(int number)
    {
        return number / 2 * 2 == number;
    }
}
