using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Projectiles : MonoBehaviour
{
    public float m_speed { get; protected set; }
    protected abstract float defaultSpeed { get; }

    public float m_boundary { get; protected set; }
    protected abstract float defaultBoundary { get; }

    private void Awake()
    {
        m_speed = defaultSpeed;
        m_boundary = defaultBoundary;
    }

    // Update is called once per frame
    void Update()
    {
        ProjectileMovement(m_speed);
        ProjectileBoundary(m_boundary);

    }

    void ProjectileMovement(float speed)
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }

    void ProjectileBoundary(float boundaryY)
    {
        if (transform.position.y >= boundaryY && boundaryY > 0)
        {
            Destroy(gameObject);
        }
        if (transform.position.y <= boundaryY && boundaryY < 0)
        {
            Destroy(gameObject);
        }

    }
}
