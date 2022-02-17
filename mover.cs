using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    [SerializeField]
    private Vector3 acceleration;
    [SerializeField]
    [Range (-1,1)]
    private float damping = 1.0f;

    private Vector3 position, velocity;

    public void Move()
    {
        
        if ((position.x > 5) || (position.x < -5))
        {
            velocity.x = velocity.x * -1;
            velocity.x -= velocity.x * damping;
        }
        if ((position.y > 5) || (position.y < -5))
        {
            velocity.y = velocity.y * -1;
            velocity.y -= velocity.y * damping;
        }
        velocity += acceleration * Time.deltaTime;
        position += velocity * Time.deltaTime;
        transform.position = position;
    }

    private void Draw()
    {
        Debug.DrawLine(transform.position, velocity, Color.blue);
        Debug.DrawLine(transform.position, position, Color.red);
        //Debug.DrawLine(transform.position, acceleration, Color.green);
    }
    void Start()
    {
        position = transform.position;
        //acceleration = acceleration * damping;
    }

    void Update()
    {
        Move();
        Draw();
    }
}
