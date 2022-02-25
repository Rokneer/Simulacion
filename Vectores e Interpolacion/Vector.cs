using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Vector
{
    public float x, y;

    public Vector(float xcomponent, float ycomponent)
    {
        x = xcomponent;
        y = ycomponent;
    }
    public override string ToString()
    {
        return x + ", " + y;
    }

    public Vector add(Vector vector)
    {
        Vector result = new Vector(x + vector.x, y + vector.y);
        return result;
    }

    public Vector sub(Vector vector)
    {
        Vector result = new Vector(x - vector.x, y - vector.y);
        return result;
    }
    public Vector multi(float num)
    {
        Vector result = new Vector(x * num, y * num);
        return result;
    }
    public float magni()
    {
        float Result = Mathf.Sqrt((x * x) + (y * y));
        return Result;
    }
    public Vector normalice()
    {

        Vector result = new Vector(x / magni(), y / magni());
        return result;
    }

    public Vector lerp(Vector vector, float scale)
    {
        return new Vector((x * (1 - scale) + (vector.x * scale)), (y * (1 - scale) + (vector.y * scale)));
    }

    public void Draw(Vector origin = null)
    {
        if (origin == null)
        {
            Debug.DrawLine(new Vector2(0, 0), new Vector2(x, y));
            return;
        }
        Debug.DrawLine(new Vector2(origin.x, origin.y), new Vector2(x + origin.x, y + origin.y));
    }

    public static Vector operator +(Vector a, Vector b)
    {
        return new Vector(a.x + b.x, a.y + b.y);
    }
    public static Vector operator -(Vector a, Vector b)
    {
        return new Vector(a.x - b.x, a.y - b.y);
    }
    public static Vector operator *(Vector a, float scalar)
    {
        return new Vector(a.x * scalar, a.y * scalar);
    }
    public static Vector operator /(Vector a, float scalar)
    {
        return new Vector(a.x / scalar, a.y / scalar);
    }
}
