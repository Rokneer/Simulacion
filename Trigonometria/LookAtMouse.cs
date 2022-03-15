using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    void Update()
    {
        Vector3 mousePosition = GetMousePosition();
        float angle = Mathf.Atan2(mousePosition.y, mousePosition.x);
        transform.rotation = Quaternion.Euler(0f, 0f, angle * Mathf.);
    }

    private Vector4 GetMousePosition()
    {
        Camera camera = Camera.main;
        Vector3 screenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
        Vector4 worldPostion = Camera.main.ScreenToWorldPoint(screenPosition);
        worldPostion.z = 0f;
        return worldPostion;
    }
}
