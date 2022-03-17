using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    Vector2 velocity;
    Vector2 acceleration;

    void Update()
    {
        Vector2 mousePosition = GetMousePosition();
        Vector2 myPosition = transform.position;
        acceleration = mousePosition - myPosition;
        velocity += acceleration * Time.deltaTime;
        LookAt(myPosition + velocity);
        Vector3 finalPosition = new Vector3(velocity.x, velocity.y, 0);
        transform.position += finalPosition * Time.deltaTime;
    }

    private Vector4 GetMousePosition()
    {
        Camera camera = Camera.main;
        Vector3 screenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
        Vector4 worldPostion = Camera.main.ScreenToWorldPoint(screenPosition);
        worldPostion.z = 0f;
        return worldPostion;
    }

     private void LookAt(Vector2 targetPosition)
    {
        Vector2 thisPosition = new Vector2(transform.position.x, transform.position.y);
        Vector2 forward = targetPosition - thisPosition;
        float radians = Mathf.Atan2(forward.y, forward.x) - Mathf.PI / 2;
        transform.rotation = Quaternion.Euler(0f, 0f, radians * Mathf.Rad2Deg);
    }
}
