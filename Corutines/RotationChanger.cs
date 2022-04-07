using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationChanger : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(ChangeRot());
    }

    IEnumerator ChangeRot()
    {
        float initialRot = 0;
        transform.rotation = Quaternion.Euler(0,0,initialRot);
        while (true)
        {
            yield return new WaitForSeconds(1);
            initialRot += 45;
            transform.rotation = Quaternion.Euler(0, 0, initialRot);
        }
    }
}
