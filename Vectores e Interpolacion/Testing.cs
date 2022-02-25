using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    [SerializeField]
    Vector first = new Vector(2,3);
    [SerializeField]
    Vector second = new Vector(3, 0);
    [SerializeField]
    [Range(0, 1)]
    public float range = 0.0f;

    void Update()
    {
        first.Draw();
        second.Draw();
        var diffVector = second.sub(first);
        diffVector.multi(range).Draw();
        diffVector.Draw(first);
        first.lerp(second, range).Draw();
    }
}
