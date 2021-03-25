using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorHelper : MonoBehaviour
{
    public static void SetX(ref Vector2 vector, float value)
    {
        vector.Set(value, vector.y);
    }

    public static Vector2 SetX(Vector2 vector, float value)
    {
        SetX(ref vector, value);
        return vector;
    }

    public static void SetY(ref Vector2 vector, float value)
    {
        vector.Set(vector.x, value);
    }

    public static Vector2 SetY(Vector2 vector, float value)
    {
        SetY(ref vector, value);
        return vector;
    }
    public static void SetX(ref Vector3 vector, float value)
    {
        vector.Set(value, vector.y, vector.z);
    }

    public static Vector3 SetX(Vector3 vector, float value)
    {
        SetX(ref vector, value);
        return vector;
    }

    public static void SetY(ref Vector3 vector, float value)
    {
        vector.Set(vector.x, value, vector.z);
    }

    public static Vector3 SetY(Vector3 vector, float value)
    {
        SetY(ref vector, value);
        return vector;
    }

    public static void SetZ(ref Vector3 vector, float value)
    {
        vector.Set(vector.x, vector.y, value);
    }

    public static Vector3 SetZ(Vector3 vector, float value)
    {
        SetZ(ref vector, value);
        return vector;
    }

    public static void SetA(ref Color color, float value)
    {
        color = new Color(color.r, color.g, color.b, value);
    }

    public static Color SetA(Color color, float value)
    {
        SetA(ref color, value);
        return color;
    }

    public static Vector2 DegreesToVector2(float z)
    {
        return new Vector2(Mathf.Cos(z * Mathf.Deg2Rad), Mathf.Sin(z * Mathf.Deg2Rad));
    }

    public static float Vector2ToDegrees(Vector2 vector)
    {
        vector.Normalize();
        return Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg;
    }

    public static void Rotate(ref Vector2 vector, float degrees)
    {
        float oldDegrees = Vector2ToDegrees(vector);
        float oldDistance = Vector2.Distance(Vector2.zero, vector);
        vector = DegreesToVector2(oldDegrees + degrees) * oldDistance;
    }

    public static Vector2 Rotate(Vector2 vector, float degrees)
    {
        Rotate(ref vector, degrees);
        return vector;
    }

    public static void SnapToGrid(ref Vector2 point, Vector2 gridSize, Vector2 offset)
    {
        float x = point.x + offset.x;
        float y = point.y + offset.y;
        SnapFloat(ref x, gridSize.x);
        SnapFloat(ref y, gridSize.y);
        point = new Vector2(x, y) - offset;
    }

    public static Vector2 SnapToGrid(Vector2 point, Vector2 gridSize, Vector2 offset)
    {
        SnapToGrid(ref point, gridSize, offset);
        return point;
    }

    private static void SnapFloat(ref float value, float ruler)
    {
        value /= ruler;
        value = Mathf.Round(value);
        value *= ruler;
    }
}
