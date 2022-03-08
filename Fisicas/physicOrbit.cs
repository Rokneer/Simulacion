using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physicOrbit : MonoBehaviour
{
    [SerializeField] private float mass = 1;
    [SerializeField] private Vector3 velocity;
    private Vector3 acceleration;

    [SerializeField] private Transform target;
    [SerializeField] private float targetMass = 1;

    void Update()
    {
        acceleration = Vector3.zero;

        Vector3 difference = target.position - transform.position;
        float distance = difference.magnitude;
        float attractionForceScalar = (mass * targetMass) / distance * distance;
        Vector3 force = attractionForceScalar * difference.normalized;
        ApplyForce(force);

        Move();
    }

    private void Move()
    {
        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;
    }

    private void ApplyForce(Vector3 force)
    {
        acceleration += force / mass;
    }
}