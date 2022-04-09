using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSin : MonoBehaviour
{
    [SerializeField] [Range(1, 5)] private float amplitud_x;
    [SerializeField] [Range(1, 5)] private float amplitud_y;
    [SerializeField] [Range(1, 5)] private float factor;

    private void Start()
    {
        amplitud_x = Random.Range(1, 5);
        amplitud_y = Random.Range(1, 5);
        factor = Random.Range(1, 5);
    }

    void Update()
    {
        float x = amplitud_x * Mathf.Sin(Time.time * factor);
        float y = amplitud_y * Mathf.Sin(Time.time * factor);
        transform.position = new Vector3(x, y, 0);
    }
}
