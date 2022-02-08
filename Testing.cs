using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    [SerializeField]
    Vector first;
    [SerializeField]
    Vector second;
    [SerializeField]
    [Range(0, 1)]
    public float range = 0.0f;


    void Start()
    {
        
    }

    void Update()
    {
        first.Draw();
        second.Draw();
        var diffVector = second.sub(first);
        diffVector.multi(range).Draw();
        diffVector.Draw(first);
        diffVector.lerp(second,2).Draw();

    }
}
