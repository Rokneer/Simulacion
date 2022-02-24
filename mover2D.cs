using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using MyMath;

public class mover : MonoBehaviour
{
    [SerializeField]
    private Vector3 acceleration;
    private Vector3 velocity;
    private Vector3 force;

    [SerializeField]
    [Range(0, 1)]
    private float dampFactor;
    [SerializeField]
    float mass = 1f;

    private void Update()
    {
        ApplyForce(new Vector3(0, -9.8f, 0));
        ApplyForce(new Vector3(1, 0, 0));
        Move();
        CheckLimits();
        acceleration = Vector3.zero;
    }

    public void Move()
    {
        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;

        // Debug my vectors
        //transform.position.Draw(Color.red);
        //acceleration.Draw(transform.position, Color.green);
        //velocity.Draw(transform.position, Color.blue);
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
