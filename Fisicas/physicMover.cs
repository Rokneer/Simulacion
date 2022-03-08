using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physicMover : MonoBehaviour
{
    [SerializeField]
    private Vector3 acceleration;
    private Vector3 velocity;
    private Vector3 force;

    private float gravity = -9.8f;
    private float N;

    [SerializeField]
    [Range(0, 1)]
    private float dampFactor;
    [SerializeField]
    float mass = 1f;
    [SerializeField]
    [Range(0, 1)]
    float coeficienteFriccion;

    private void Update()
    {
        acceleration = Vector3.zero;

        N = mass * gravity;
        Vector3 Friction = -velocity.normalized * N * coeficienteFriccion;

        ApplyForce(new Vector3(1, mass*gravity, 0));
        ApplyForce(Friction);

        Move();
        CheckLimits();
    }

    public void Move()
    {
        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;

    }

    private void CheckLimits()
    {
        Vector3 position = transform.position;
        if ((position.x > 5 || position.x < -5))
        {
            if (position.x > 5) transform.position = new Vector3(5, transform.position.y);
            if (position.x < -5) transform.position = new Vector3(-5, transform.position.y);

            velocity.x = velocity.x * -1;
            velocity *= dampFactor;
        }

        else if (position.y > 5 || position.y < -5)
        {

            if (position.y > 5) transform.position = new Vector3(transform.position.x, 5);
            if (position.y < -5) transform.position = new Vector3(transform.position.x, -5);
            velocity.y = velocity.y * -1;
            velocity *= dampFactor;
        }
    }

    private void ApplyForce(Vector3 force)
    {
        acceleration += force / mass;
    }

}
